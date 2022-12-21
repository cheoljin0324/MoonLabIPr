using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager
{
    private static PoolManager _instance;

    public static PoolManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new PoolManager(new GameObject("PoolManager").transform);
            }

            return _instance;
        }
    }

    private Dictionary<string, Pool<PoolableMono>> _pools = new Dictionary<string, Pool<PoolableMono>>();

    private Transform _trmParent;

    private PoolManager(Transform trmParent)
    {
        _trmParent = trmParent;
    }

    public void CreatePool(PoolableMono prefab, int count = 10)
    {
        Pool<PoolableMono> pool = new Pool<PoolableMono>(prefab, _trmParent, count);
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
