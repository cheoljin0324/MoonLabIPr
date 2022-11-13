using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class TextManager : MonoBehaviour
{
    private Dictionary<string, string> _textDictionary = new Dictionary<string, string>();

    private void Awake()
    {
        InitTextDictionary();
    }

    private void InitTextDictionary()
    {
        _textDictionary.Clear();

        Text[] texts = GetComponentsInChildren<Text>();
        foreach (Text text in texts)
        {
            _textDictionary.Add(text.name, text.text);
        }
    }

    public virtual void SetText(string textUIName, string content)
    {
        if (_textDictionary.ContainsKey(textUIName))
        {
            _textDictionary[textUIName] = content;
        }
        else
        {
            Debug.LogError("TextManager: " + textUIName + " is not exist");
        }
    }
}
