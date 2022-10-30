using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject _parent;
    public float _speed = 10.0f;

    private void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * _speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != _parent)
        {
            Destroy(gameObject);
        }
    }
}
