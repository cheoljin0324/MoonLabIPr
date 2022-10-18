using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed = 10.0f;
    public float lifeTime = 5.0f;

    public Transform target;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
