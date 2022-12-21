using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoSingleton<EnemyManager>
{

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        StartCoroutine(EnemySpawn());
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
