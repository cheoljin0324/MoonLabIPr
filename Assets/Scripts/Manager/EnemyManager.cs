using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoSingleton<EnemyManager>
{
    [SerializeField]
    private PoolingListSO _initList = null;
    
    protected override void Awake()
    {
        base.Awake();
        CreatePool();
    }
    
    private void CreatePool()
    {
        foreach (PoolingPair pair in _initList.list)
            PoolManager.Instance.CreatePool(pair.prefab, pair.poolCnt);
    }
}
