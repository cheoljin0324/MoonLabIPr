using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class TextManager : MonoSingleton<TextManager>
{
    private Dictionary<string, string> _textDictionary = new Dictionary<string, string>();

    protected override void Awake()
    {
        base.Awake();
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

    public virtual void SetText(string name, string text)
    {
        if (_textDictionary.ContainsKey(name))
        {
            _textDictionary[name] = text;
        }
        else
        {
            Debug.LogError("TextManager: " + name + " is not exist");
        }
    }
}
