using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float atkSpeed = 1.0f;
    public GameObject bullet;

    public bool canMove = true;

    void Start()
    {
        StartCoroutine(Attack());
        StartCoroutine(Move());
    }

    private IEnumerator Attack()
    {
        while (true)
        {
            if (!canMove)
            {
                yield return null;
                continue;
            }
            yield return new WaitForSeconds(Random.Range(atkSpeed, atkSpeed + 0.5f));
            GameObject bulletObj = Instantiate(bullet, transform.position, Quaternion.identity);
            bulletObj.GetComponent<Bullet>()._parent = gameObject;
        }
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
}
