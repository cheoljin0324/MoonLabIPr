using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;

public abstract class ButtonManager : MonoBehaviour
{
    private List<ButtonInfo> _buttonList = new List<ButtonInfo>();

    private void Awake()
    {
        InitButtonList();
        SetButtonEvent();
    }

    private void InitButtonList()
    {
        _buttonList.Clear();

        Button[] buttons = GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            _buttonList.Add(new ButtonInfo(button.name, button));
        }
    }

    private void SetButtonEvent()
    {
        foreach (ButtonInfo buttonInfo in _buttonList)
        {
            MethodInfo methodInfo = GetType().GetMethod("On" + buttonInfo.Name, BindingFlags.NonPublic | BindingFlags.Instance);
            if (methodInfo != null)
            {
                buttonInfo.Button.onClick.AddListener(() => methodInfo?.Invoke(this, null));
            }
        }
    }
}
