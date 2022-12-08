using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    private TankMovement _tankMovement = null;
    private Turret _turret = null;
    
    private void Awake()
    {
        _tankMovement = GetComponent<TankMovement>();
        _turret = GetComponent<Turret>();
    }
    
    private void Start()
    {
        _turret.Aim(GameObject.Find("Train").transform);
        _tankMovement.MoveTo(GameObject.Find("Train").transform.position + new Vector3(-10, -0f, 0));
    }
}
