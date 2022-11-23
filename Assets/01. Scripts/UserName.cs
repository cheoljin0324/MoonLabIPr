using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class UserName : MonoBehaviour
{
    public InputField nameInput;
    public UserDataSO _userNameSO;

    private bool CheckName()
    {
        return Regex.IsMatch(nameInput.text, "^[0-9a-zA-Z��-�R]*$");
    }

    public void CreateName()
    {
        if (CheckName() == false)
        {
            Debug.Log("�̸��� �ѱ�, ����, ���ڷθ� ���� �� �ִ�.");
            return;
        }

        _userNameSO.name = nameInput.text + " ��";

        MainUIManager.Instance.UpdateText();
        transform.GetComponent<Canvas>().enabled = false;
    }
}
