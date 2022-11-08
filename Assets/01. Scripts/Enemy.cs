using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float _hp = 100.0f;

    public bool canMove = true;
    public int spawnPointIndex = 0;

    void Start()
    {
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        Vector3 dir = new Vector3(1, 0, 0);
        while (true)
        {
            if (!canMove)
            {
                yield return null;
                continue;
            }
            yield return new WaitForSeconds(Random.Range(0.5f, 1.0f));
            dir *= -1;
            transform.Translate(dir * 0.1f);
        }
    }

    public void Damaged(float damage)
    {
        _hp -= damage;
        if (_hp <= 0)
        {
            Destroy(gameObject);
            EnemySpawn.Instance.isSpawned[spawnPointIndex] = false;
        }
    }
}
