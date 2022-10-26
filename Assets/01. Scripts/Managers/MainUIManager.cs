using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIManager : Singleton<MainUIManager>
{
    public Text nameText;
    public UserNameSO _userNameSO;

    public void UpdateText()
    {
        nameText.text = _userNameSO.name;
    }
}
