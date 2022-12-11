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

        PoolManager.Instance = new PoolManager(transform);

        CreatePool();
    }

    private void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    private void CreatePool()
    {
        foreach (PoolingPair pair in _initList.list)
            PoolManager.Instance.CreatePool(pair.prefab, pair.poolCnt);
    }

    IEnumerator EnemySpawn()
    {
        Enemy enemy;
        yield return new WaitForSeconds(3f);
        while (true)
        {
            enemy = PoolManager.Instance.Pop("Tank_G") as Enemy;

            float randomPosZ = Random.Range(-20f, 0f);
            Vector3 pos = CombatManager.Instance.Train.transform.position;
            pos.x -= 7f;
            pos.z += randomPosZ;

            enemy.transform.position = pos;
            yield return new WaitForSeconds(3f);
        }
    }
}
