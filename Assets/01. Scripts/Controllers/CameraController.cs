using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraController : MonoBehaviour, IDragHandler
{
    public float cameraMoveSpeed = 10f;
    public GameObject _camera;

    private Vector2 mouseDownPos;
    private Vector2 mousePos;


    public void OnDrag(PointerEventData eventData)
    {
        
        mousePos = Input.mousePosition;
        if(mousePos.x < mouseDownPos.x)
        {
            _camera.transform.Translate(cameraMoveSpeed * Time.deltaTime, 0, 0);
        }
        else if (mousePos.x > mouseDownPos.x)
        {
            _camera.transform.Translate(-cameraMoveSpeed * Time.deltaTime, 0, 0);
        }
        mouseDownPos = Input.mousePosition;
    }

    public void OnMouseDown()
    {
        mouseDownPos = Input.mousePosition;
    }
}
