using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TargetDetector : MonoBehaviour
{
    [SerializeField]
    private string _targetTag = "";
    
    [SerializeField]
    private float _range = 10f;

    private List<Transform> _targets = new List<Transform>();

    public List<Transform> TargetsInRange
    {
        get
        {
            Debug.Log("TargetsInRange");
            if(_targets.Count < 1)
            {
                FindTargets();
            }
            
            return _targets.Where(t => Vector3.Distance(transform.position, t.position) <= _range).ToList();
        }
    }

    public Transform NearestTarget
    {
        get
        {
            if (TargetsInRange.Count == 0)
            {
                return null;
            }

            return TargetsInRange.OrderBy(t => Vector3.Distance(transform.position, t.position)).First();
        }
    }
    
    private void FindTargets()
    {
        _targets.Clear();
        _targets.AddRange(GameObject.FindGameObjectsWithTag(_targetTag).Select(x => x.transform));
    }
}
