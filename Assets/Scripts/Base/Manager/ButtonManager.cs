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
        InitButtonDictionary();
        SetButtonEvent();
    }

    private void InitButtonDictionary()
    {
        _buttonDictionary.Clear();

        Button[] buttons = GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            if (_buttonDictionary.ContainsKey(button.name))
            {
                Debug.LogError($"Please check the button name. There is a duplicate name. {button.name}");
            }
            else
            {
                _buttonDictionary.Add(button.name, button);
            }
        }
    }

    private void SetButtonEvent()
    {
        foreach (string buttonInfo in _buttonDictionary.Keys)
        {
            MethodInfo methodInfo = this.GetType().GetMethod("On" + buttonInfo + "Clicked", BindingFlags.Public|BindingFlags.Instance);
            if (methodInfo != null)
            {
                _buttonDictionary[buttonInfo].onClick.AddListener(() => methodInfo?.Invoke(this, null));
            }
            else
            {
                Debug.LogWarning($"Can't found {buttonInfo}'s method");
            }
        }
    }
}
