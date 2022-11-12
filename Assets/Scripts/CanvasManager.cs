using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoSingleton<CanvasManager>
{
    Dictionary<string, Canvas> _canvasDictionary = new Dictionary<string, Canvas>();

    protected override void Awake()
    {
        base.Awake();
        InitCanvasDictionary();
    }

    private void InitCanvasDictionary()
    {
        _canvasDictionary.Clear();
        
        Canvas[] canvases = FindObjectsOfType<Canvas>();

        foreach (Canvas canvas in canvases)
        {
            _canvasDictionary.Add(canvas.name, canvas);
        }
    }

    public void ChangeCanvas(string currentCanvas, string newCanvas)
    {
        if (_canvasDictionary.ContainsKey(currentCanvas) && _canvasDictionary.ContainsKey(newCanvas))
        {
            _canvasDictionary[currentCanvas].enabled = false;
            _canvasDictionary[newCanvas].enabled = true;
        }
        else
        {
            Debug.LogError($"Can't find Canvas {currentCanvas} or {newCanvas}");
        }
    }
}
