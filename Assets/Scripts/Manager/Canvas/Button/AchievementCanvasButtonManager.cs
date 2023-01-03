using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementCanvasButtonManager : ButtonManager
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

    public void OnMainMenuButtonClicked()
    {
        // 사라질 수도 있는 캔버스
        CanvasManager.Instance.ChangeCanvas("AchievementCanvas", "MenuCanvas");
    }
}
