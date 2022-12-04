 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 endPosition;

    private bool isClicking = false;
    private bool wasClicking = false;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isClicking)
            {
                
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isClicking = false;
        }
        
        
    }
}
