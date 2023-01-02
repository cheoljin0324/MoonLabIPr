using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuCanvasButtonManager : ButtonManager
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

    public void OnSupplyButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("MenuCanvas", "MapSelectCanvas");
    }

    public void OnUpgradeButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("MenuCanvas", "TrainCarUpgradeCanvas");
    }

    public void OnOrganizationButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("MenuCanvas", "OrganizationCanvas");
    }

    public void OnAchievementButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("MenuCanvas", "AchievementCanvas");
    }

    public void OnTrainCarListButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("MenuCanvas", "TrainCarListCanvas");
    }

    public void OnShopButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("MenuCanvas", "ShopCanvas");
    }

    public void OnMessageButtonClicked()
    {
        Debug.Log("OnMessageButton");
    }

    public void OnSettingButtonClicked()
    {
        Debug.Log("OnSettingButton");
    }

    public void OnCalendarButtonClicked()
    {
        Debug.Log("OnCalendarButton");
    }
}
