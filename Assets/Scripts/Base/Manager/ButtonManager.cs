using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Reflection;
using UnityEngine;

public abstract class ButtonManager : MonoBehaviour
{
    private Dictionary<string, Button> _buttonDictionary = new Dictionary<string, Button>();

    private void Awake()
    {
        InitButtonList();
        SetButtonEvent();
    }

    private void InitButtonList()
    {
        _buttonDictionary.Clear();

        Button[] buttons = GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            _buttonDictionary.Add(button.name, button);
        }
    }

    private void SetButtonEvent()
    {
        foreach (string buttonInfo in _buttonDictionary.Keys)
        {
            MethodInfo methodInfo = this.GetType().GetMethod("On" + buttonInfo, BindingFlags.Public|BindingFlags.Instance);
            if (methodInfo != null)
            {
                _buttonDictionary[buttonInfo].onClick.AddListener(() => methodInfo?.Invoke(this, null));
            }
        }
    }
}
