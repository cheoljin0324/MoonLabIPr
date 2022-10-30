using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public enum Direction
{
    Left,
    Right
}

public class MapMover : MonoBehaviour
{
    private Vector2 touchStart;
    private Vector2 touchEnd;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchStart = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            touchEnd = Input.mousePosition;
            transform.Rotate(0, (touchStart.x - touchEnd.x) * Time.deltaTime * 15, 0);
            touchStart = touchEnd;
        }
        if (Input.GetMouseButtonUp(0))
        {
            touchEnd = Input.mousePosition;
            RotateMap();
        }
    }

    void RotateMap()
    {
        float curAngle = transform.eulerAngles.y;
        float minAngle = 180.0f;
        int[] angles = { -90, 0, 90, 180 };
        int minIndex = 0;

        for (int i = 0; i < 4; ++i)
        {
            float angle = Mathf.Abs(curAngle - angles[i]) >= 180.0f ? 360.0f - Mathf.Abs(curAngle - angles[i]) : Mathf.Abs(curAngle - angles[i]);

            if (Mathf.Abs(angle) < Mathf.Abs(minAngle))
            {
                minAngle = angle;
                minIndex = i;
            }
        }

        // -90 <= angle < 0
        // -10
        // 10
        // 80
        // 100
        // 190


        float angleToRotate = angles[minIndex];

        transform.DORotate(new Vector3(0, angleToRotate, 0), 0.5f);
    }
}
