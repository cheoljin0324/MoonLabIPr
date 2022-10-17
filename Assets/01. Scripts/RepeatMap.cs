using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatMap : MonoBehaviour
{
    public float mapMoveSpeed = 5f;
    public bool nextMap = false;

    private void Start()
    {
        InvokeRepeating("MoveMap", 5f, 4.9f);
    }

    private void Update()
    {
        gameObject.transform.Translate(new Vector3(mapMoveSpeed, 0, 0));
    }

    private void MoveMap()
    {
        if(nextMap == true)
        {
            nextMap = false;
            return;
        }

        gameObject.transform.Translate(new Vector3(-800f, 0, 0));
        nextMap = true;
    }
}
