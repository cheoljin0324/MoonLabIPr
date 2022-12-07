using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform target;
    
    void Update()
    {
        Vector2 direction = new Vector2(target.position.x - transform.position.x, target.position.z - transform.position.z);
        direction.Normalize();
        
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-90f, Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + 90f, 0f), 0.1f);
    }
}
