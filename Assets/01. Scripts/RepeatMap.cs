using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatMap : MonoBehaviour
{
    public float mapMoveSpeed = 5f;

    private void Update()
    {
        gameObject.transform.Translate(new Vector3(mapMoveSpeed, 0, 0));
    }
}
