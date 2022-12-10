using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDetector : MonoBehaviour
{
    [SerializeField]
    private string _targetTag = "";
    
    [SerializeField]
    private float _range = 10f;
    
    private Transform[] _targets = null;

    public Transform[] Targets
    {
        get
        {
            return _targets;
        }
    }
    
    private Transform _nearestTarget = null;
    public Transform NearestTarget
    {
        get
        {
            if (_nearestTarget == null)
            {
                _nearestTarget = FindNearestTarget();
            }
            return _nearestTarget;
        }
    }

    private void Start()
    {
        DetectTargets();
    }

    public Transform[] DetectTargets()
    {
        return Array.Empty<Transform>();
    }
    
    public Transform[] FindTargetsInRange()
    {
        List<Transform> targetsInRange = new List<Transform>();
        foreach (Transform target in _targets)
        {
            if (Vector3.Distance(transform.position, target.position) <= _range)
            {
                targetsInRange.Add(target);
            }
        }
        return targetsInRange.ToArray();
    }
    
    public Transform FindNearestTarget()
    {
        Transform nearestTarget = null;
        float nearestDistance = Mathf.Infinity;
        foreach (Transform target in _targets)
        {
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance < nearestDistance)
            {
                nearestDistance = distance;
                nearestTarget = target;
            }
        }
        _nearestTarget = nearestTarget;
        return _nearestTarget;
    }
}
