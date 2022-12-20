﻿using System.Collections;
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

    private Transform _target = null;

    public Transform Target
    {
        get => _target;
        set => _target = value;
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
            for (int i = 0; i < _turret.Length; i++)
            {
                Vector2 direction = new Vector2(_target.position.x - _turret[i].position.x, _target.position.z - _turret[i].position.z);
                direction.Normalize();
                _turret[i].rotation = Quaternion.Lerp(_turret[i].rotation, Quaternion.Euler(_defaultRotation.x, Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + _defaultRotation.y, _defaultRotation.z), _rotationSpeed * Time.deltaTime);
            }
            yield return null;
        }

        for (int i = 0; i < _turret.Length; i++)
        {
            _turret[i].rotation = Quaternion.Lerp(_turret[i].rotation, Quaternion.Euler(_defaultRotation), _rotationSpeed * Time.deltaTime);
        }
    }

    private void HitEffect()
    {
        PoolableMono effect = PoolManager.Instance.Pop("Explosion8");
        // 피격 당한 포지션으로 수정해야함
        //effect.transform.position = hit.position;
    }
}
