using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField]
    private Transform[] _turret = null;

    [SerializeField]
    private float _rotationSpeed = 1f;

    [SerializeField]
    private Vector3 _defaultRotation = Vector3.zero;

    [SerializeField]
    private LayerMask _targetLayer = 0;

    private Transform _target = null;

    public Transform Target
    {
        get => _target;
        set => _target = value;
    }

    private bool _isAiming = false;
    public bool IsAiming
    {
        get => _isAiming;
    }

    public void Aim(Transform target)
    {
        _target = target;
        StartCoroutine(nameof(LookTarget));
    }

    public void Aim()
    {
        StartCoroutine(nameof(LookTarget));
    }

    public void Release()
    {
        _target = null;
    }

    private IEnumerator LookTarget()
    {
        while (_target != null)
        {
            _isAiming = true;
            for (int i = 0; i < _turret.Length; i++)
            {
                Vector2 direction = new Vector2(_target.position.x - _turret[i].position.x, _target.position.z - _turret[i].position.z);
                direction.Normalize();
                _turret[i].rotation = Quaternion.Lerp(_turret[i].rotation, Quaternion.Euler(_defaultRotation.x, Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + _defaultRotation.y, _defaultRotation.z), _rotationSpeed * Time.deltaTime);
                if (_turret[i].rotation == Quaternion.Euler(_defaultRotation.x, Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + _defaultRotation.y, _defaultRotation.z))
                {
                    _isAiming = false;
                }
            }
            yield return null;
        }

        for (int i = 0; i < _turret.Length; i++)
        {
            _turret[i].rotation = Quaternion.Lerp(_turret[i].rotation, Quaternion.Euler(_defaultRotation), _rotationSpeed * Time.deltaTime);
        }
    }

    private void Update()
    {
        for (int i = 0; i < _turret.Length; i++)
        {
            Vector3 direction = Quaternion.AngleAxis(-_defaultRotation.y, _turret[i].up) * _turret[i].forward;

            Debug.DrawRay(_turret[i].position, direction * 20f, Color.red);
        }
    }

    public void Fire()
    {
        StartCoroutine(nameof(FireCoroutine));
    }

    private IEnumerator FireCoroutine()
    {
        for (int i = 0; i < _turret.Length; i++)
        {
            Vector3 direction = _target.position - _turret[i].position;
            RaycastHit hit;
            if (Physics.Raycast(_turret[i].position, direction, out hit, Mathf.Infinity, _targetLayer))
            {
                HitEffectManager.Instance.CreateHitEffect(hit.point);
            }
            yield return new WaitForSeconds(0.25f);
        }
    }
}