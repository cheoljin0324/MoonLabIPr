using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RouteCanvasSliderController : Singleton<RouteCanvasSliderController>
{
    private float curPos = 0.0f;
    public float speed = 0.0f;
    public float targetPos = 100.0f;
    public Text distanceText;

    public Slider _slider;

    public Canvas clearCanvas;

    public bool isEnd = false;

    void Start()
    {
        _slider.value = 0.0f;
        _slider.maxValue = targetPos;
    }

    void Update()
    {
        if (curPos < targetPos)
        {
            curPos += Time.deltaTime * speed;
            _slider.value = curPos;
            distanceText.text = curPos.ToString("0.0") + "km";
        }
        else
        {
            //SceneController.Instance.LoadScene("MainScene");
            if(isEnd == false)
            {
                isEnd = true;
                Invoke("GameEnd", 3f);
            }
        }
    }

    private void GameEnd()
    {
        clearCanvas.enabled = true;
    }

    public void ExitPlayScene()
    {
        SceneController.Instance.LoadScene("MainScene");
    }
}
