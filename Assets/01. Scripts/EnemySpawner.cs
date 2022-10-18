using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    private float spawnDelay;

    private void Start()
    {
        StartCoroutine(nameof(SpawnEnemy));
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            spawnDelay = Random.Range(0.5f, 3.0f);
            GameObject enemyTemp = Instantiate(enemy, new Vector3(9.0f, 0.5f, 40.0f), Quaternion.identity);
            Destroy(enemyTemp, 8.0f);
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
