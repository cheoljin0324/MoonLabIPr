using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoSingleton<CanvasManager>
{
    [SerializeField]
    private string _defaultCanvasName = null;

    private Dictionary<string, Canvas> _canvasDictionary = new Dictionary<string, Canvas>();

    protected override void Awake()
    {
        base.Awake();
        InitCanvasDictionary();
    }

    private void Start()
    {
        foreach (var key in _canvasDictionary.Keys)
        {
            _canvasDictionary[key].enabled = key == _defaultCanvasName;
        }
    }

    private void InitCanvasDictionary()
    {
        _canvasDictionary.Clear();
        
        Canvas[] canvases = GetComponentsInChildren<Canvas>();

        foreach (Canvas canvas in canvases)
        {
            _canvasDictionary.Add(canvas.name, canvas);
        }
    }

    public void ChangeCanvas(string currentCanvas, string nextCanvas)
    {
        if (_canvasDictionary.ContainsKey(currentCanvas) && _canvasDictionary.ContainsKey(nextCanvas))
        {
            _canvasDictionary[currentCanvas].enabled = false;
            _canvasDictionary[nextCanvas].enabled = true;
        }
        else
        {
            Debug.LogError($"Can't find Canvas {currentCanvas} or {nextCanvas}");
        }
    }
    
    public void ChangeCanvas(string nextCanvas)
    {
        if (_canvasDictionary.ContainsKey(nextCanvas))
        {
            foreach (var key in _canvasDictionary.Keys)
            {
                _canvasDictionary[key].enabled = key == nextCanvas;
            }
        }
        else
        {
            Debug.LogError($"Can't find Canvas {nextCanvas}");
        }
    }
}
