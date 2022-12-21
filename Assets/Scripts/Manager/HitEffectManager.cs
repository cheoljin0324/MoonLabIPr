using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffectManager : MonoSingleton<HitEffectManager>
{
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
