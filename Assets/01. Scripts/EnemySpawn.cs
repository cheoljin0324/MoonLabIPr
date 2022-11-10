using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : Singleton<EnemySpawn>
{
    public Transform[] spawnPoints;

    [HideInInspector]
    public bool[] isSpawned;

    public GameObject[] enemyPrefab;

    public float spawnTime = 5f;

    private void Start()
    {
        isSpawned = new bool[spawnPoints.Length];
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (RouteCanvasSliderController.Instance.isEnd == false)
        {
            yield return new WaitForSeconds(spawnTime);
            int spawnPointIndex = GetRandomSpawnPointIndex();
            int enemyIndex = Random.Range(0, enemyPrefab.Length);
            GameObject enemy = Instantiate(enemyPrefab[enemyIndex], spawnPoints[spawnPointIndex].position, Quaternion.Euler(-90, 0, -90));
            enemy.GetComponent<Enemy>().spawnPointIndex = spawnPointIndex;
            isSpawned[spawnPointIndex] = true;
        }
    }

    private int GetRandomSpawnPointIndex()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        if (isSpawned[spawnPointIndex])
        {
            return GetRandomSpawnPointIndex();
        }
        else
        {
            return spawnPointIndex;
        }
    }
}
