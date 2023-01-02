using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrganizationCanvasButtonManager : ButtonManager
{
    [SerializeField]
    private Text _moneyText;
    [SerializeField]
    private Text _mathiasText;

    private void Start()
    {
        _moneyText.text = PlayerPrefs.GetInt("Money").ToString();
        _mathiasText.text = PlayerPrefs.GetInt("Mathias").ToString();
    }

    public void OnHomeButtonClicked()
    {
        // 사라질 수도 잇는 함수
        CanvasManager.Instance.ChangeCanvas("OrganizationCanvas", "MenuCanvas");
    }
}
