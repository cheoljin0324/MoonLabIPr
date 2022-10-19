using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTime : MonoBehaviour
{
    public Slider slider;

    public Text text;

    public float time = 20.0f;

    private void Start()
    {
        slider.maxValue = time;
        slider.value = time;
    }

    private void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            time = 0;
        }
        slider.value = time;
        text.text = time.ToString("F2") + " seconds";

        if (time == 0)
        {
            Application.Quit();
        }
    }
}
