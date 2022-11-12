using UnityEngine.UI;

[System.Serializable]
public class TextInfo
{
    private string _name;
    public string Name => _name;

    private Text _text;
    public Text Text => _text;

    public TextInfo(string name, Text text)
    {
        _name = name;
        _text = text;
    }
}