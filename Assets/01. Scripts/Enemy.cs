using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float speed = 0.5f;

    private void Update()
    {
        gameObject.transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
    }
}