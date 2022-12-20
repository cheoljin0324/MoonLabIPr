using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    private TankMovement _tankMovement = null;
    private Turret _turret = null;
    private TargetDetector _targetDetector = null;

    public TankMovement TankMovement => _tankMovement;
    public Turret Turret => _turret;
    public TargetDetector TargetDetector => _targetDetector;

    private void Awake()
    {
        _tankMovement = GetComponent<TankMovement>();
        _turret = GetComponent<Turret>();
        _targetDetector = GetComponent<TargetDetector>();
    }

    private void Start()
    {
        //_tankMovement.MoveTo(new Vector3(0,0,0));
    }
}
