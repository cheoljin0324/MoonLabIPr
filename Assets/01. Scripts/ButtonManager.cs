using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject mapCanvas;
    public void OpenMapCanvas()
    {
        mapCanvas.SetActive(true);
    }
}
