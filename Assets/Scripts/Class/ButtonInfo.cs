using UnityEngine.UI;

[System.Serializable]
public class ButtonInfo
{
    private string _name;
    public string Name => _name;

    private Button _button;
    public Button Button => _button;

    public ButtonInfo(string name, Button button)
    {
        _name = name;
        _button = button;
    }
}
