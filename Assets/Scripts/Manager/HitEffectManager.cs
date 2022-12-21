using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffectManager : MonoSingleton<HitEffectManager>
{
    [SerializeField]
    private PoolableMono _hitEffect = null;

    [SerializeField]
    private PoolableMono _explosionEffect = null;

    private void Start()
    {
        PoolManager.Instance.CreatePool(_hitEffect, 100);
        PoolManager.Instance.CreatePool(_explosionEffect, 5);
    }

    public void CreateHitEffect(Vector3 position)
    {
        PoolableMono poolableMono;
        poolableMono = PoolManager.Instance.Pop("Exploson8");
        poolableMono.transform.position = position;
    }

    public void CreateExplosionEffect(Vector3 position)
    {
        PoolableMono poolableMono;
        poolableMono = PoolManager.Instance.Pop("Exploson2");
        poolableMono.transform.position = position;
    }
}
