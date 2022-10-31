using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    const float HALF_POSITION_X = 115.42f;

    public Canvas[] _canvases = null;

    public float[] _changePointX = null;

    void Start()
    {
        _canvases = GetComponentsInChildren<Canvas>();
        _changePointX = new float[_canvases.Length - 1];
        for (int i = 0; i < _changePointX.Length; i++)
        {
            _changePointX[i] = HALF_POSITION_X * (i + 1);
        }
    }

    private void Update()
    {
        // 여기 부분만 고치면 될듯
        for (int i = 0; i < _changePointX.Length; i++)
        {
            if (Camera.main.transform.position.x < _changePointX[i])
            {
                ChangeCanvas(i);
                break;
            }
        }
    }

    public void ChangeCanvas(int index)
    {
        for (int i = 0; i < _canvases.Length; i++)
        {
            if (i == index)
            {
                _canvases[i].enabled = true;
            }
            else
            {
                _canvases[i].enabled = false;
            }
        }
    }
}
