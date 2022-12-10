using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    private TankMovement _tankMovement = null;
    private Turret _turret = null;
    private TargetDetector _targetDetector = null;
    
    private void Awake()
    {
        _tankMovement = GetComponent<TankMovement>();
        _turret = GetComponent<Turret>();
        _targetDetector = GetComponent<TargetDetector>();
    }
    
    private void Start()
    {
        _targetDetector.DetectTargets();
        _turret.Aim(_targetDetector.FindNearestTarget());
    }
}
