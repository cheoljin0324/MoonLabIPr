using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultTime : MonoBehaviour
{
    public float time = 20.0f;

    private void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            time = 0;
        }
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 20;
        style.normal.textColor = Color.black;
        GUI.Label(new Rect(10, 10, 100, 20), time.ToString("F2") + " seconds left to the destination", style);

        if (time == 0)
        {
            style.normal.textColor = Color.red;
            GUI.Label(new Rect(50, 100, 100, 50), "You have arrived at the destination", style);
            Application.Quit();
        }
    }

}
