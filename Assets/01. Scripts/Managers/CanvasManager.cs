using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    const float HALF_POSITION_X = 115.42f;

    private Canvas[] _canvases = null;

    void Start()
    {
        _canvases = GetComponentsInChildren<Canvas>();
        foreach (var canvas in _canvases)
        {
            Debug.Log(canvas.name);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
