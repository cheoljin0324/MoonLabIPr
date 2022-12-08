using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] 
    private Transform _turret = null;
    
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
            Vector2 direction = new Vector2(_target.position.x - _turret.position.x, _target.position.z - _turret.position.z);
            direction.Normalize();
            
            _turret.rotation = Quaternion.Lerp(_turret.rotation, Quaternion.Euler(_defaultRotation.x, Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + _defaultRotation.y, _defaultRotation.z), _rotationSpeed * Time.deltaTime);
            
            yield return null;
        }
        
        _turret.rotation = Quaternion.Lerp(_turret.rotation, Quaternion.Euler(_defaultRotation), _rotationSpeed * Time.deltaTime);
    }
}
