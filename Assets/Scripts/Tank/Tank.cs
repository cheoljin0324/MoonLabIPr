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

    public event Action OnTankDestroyed;

    [SerializeField]
    private float _hp = 100f;

    private void Awake()
    {
        _tankMovement = GetComponent<TankMovement>();
        _turret = GetComponent<Turret>();
        _targetDetector = GetComponent<TargetDetector>();
    }

    public void DestroyTank()
    {
        Debug.Log("Tank Destroyed");
        HitEffectManager.Instance.CreateExplosionEffect(transform.position);
        OnTankDestroyed?.Invoke();
        gameObject.SetActive(false);
    }

    public void TakeDamage(float damage)
    {
        _hp -= damage;

        if (_hp <= 0f)
            DestroyTank();
    }
}
