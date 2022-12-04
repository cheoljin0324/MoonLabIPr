 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
      private void Update()
      { 
          if (Input.GetKey(KeyCode.LeftArrow))
          {
              transform.Translate(Vector3.left * 10f * Time.deltaTime);
          }

          if (Input.GetKey(KeyCode.RightArrow))
          {
              transform.Translate(Vector3.right * 10f * Time.deltaTime);
          }

          transform.position = new Vector3(transform.position.x, transform.position.y,Mathf.Clamp(transform.position.z, -40f, 0f));
      }
}
