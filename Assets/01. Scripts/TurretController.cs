using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public GameObject bullet;
    private List<GameObject> enemyList = new List<GameObject>();

    void Start()
    {
        StartCoroutine(FindEnemy());
    }

    void Update()
    {

    }

    private IEnumerator FindEnemy()
    {
        while (true)
        {
            Collider[] collider = Physics.OverlapSphere(transform.position, 10.0f);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
