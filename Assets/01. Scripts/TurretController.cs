using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public GameObject bullet;
    public float crossroad = 12.0f;
    public LayerMask layerMask;
    private List<GameObject> enemyList = new List<GameObject>();

    private Transform target = null;

    private bool isFinding = false;

    void Update()
    {
        if (target == null)
        {
            StartCoroutine(nameof(FindEnemy));
        }
    }

    private IEnumerator FindEnemy()
    {
        if (isFinding)
        {
            yield break;
        }
        isFinding = true;
        while (true)
        {
            Collider[] collider = Physics.OverlapSphere(transform.position, crossroad, layerMask);
            if (collider.Length > 0)
            {
                target = collider[0].transform;
                StartCoroutine(nameof(Attack));
                break;
            }
            yield return new WaitForSeconds(0.5f);
        }
    }

    private IEnumerator Attack()
    {
        while (true)
        {
            if (target != null && Vector3.Distance(transform.position, target.position) < crossroad)
            {
                transform.LookAt(target);
                GameObject bulletObject = Instantiate(bullet, transform.position, Quaternion.identity);
                bulletObject.GetComponent<BulletMove>().target = target;
                yield return new WaitForSeconds(1.0f);
            }
            else
            {
                target = null;
                break;
            }
            yield return null;
        }
        isFinding = false;
    }
}
