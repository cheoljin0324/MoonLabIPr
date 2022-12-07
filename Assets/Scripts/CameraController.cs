 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10f;
    
      private void Update()
      { 
          if (Input.GetKey(KeyCode.LeftArrow))
          {
              transform.Translate(Vector3.left * _speed * Time.deltaTime);
          }

          if (Input.GetKey(KeyCode.RightArrow))
          {
              transform.Translate(Vector3.right * _speed * Time.deltaTime);
          }

          //transform.position = new Vector3(transform.position.x, transform.position.y,Mathf.Clamp(transform.position.z, -50f, 0f));
      }
}
