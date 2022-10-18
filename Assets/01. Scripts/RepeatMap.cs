using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatMap : MonoBehaviour
{
    public float mapMoveSpeed = 50f;

    private void Update()
    {
        gameObject.transform.Translate(new Vector3(mapMoveSpeed * Time.deltaTime, 0, 0));
    }
}
