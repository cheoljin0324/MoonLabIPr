﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoSingleton<PoolManager>
{

    [SerializeField]
    private PoolingListSO _initList = null;
    private Dictionary<string, Pool<PoolableMono>> _pools = new Dictionary<string, Pool<PoolableMono>>();

    protected override void Awake()
    {
        base.Awake();

        _pools.Clear();
        foreach (PoolingPair pair in _initList.list)
            PoolManager.Instance.CreatePool(pair.prefab, pair.poolCnt);
    }

    public void CreatePool(PoolableMono prefab, int count = 10)
    {
        Pool<PoolableMono> pool = new Pool<PoolableMono>(prefab, transform, count);
        _pools.Add(prefab.gameObject.name, pool);
    }

    public PoolableMono Pop(string prefabName)
    {
        // 프리팹 이름으로 찾기
        if (!_pools.ContainsKey(prefabName))
        {
            Debug.LogError("Prefab doesnt exist on pool");
            return null;
        }

        PoolableMono item = _pools[prefabName].Pop();
        item.Reset();
        return item;
    }

    public void Push(PoolableMono obj)
    {
        _pools[obj.name.Trim()].Push(obj);
    }
}
