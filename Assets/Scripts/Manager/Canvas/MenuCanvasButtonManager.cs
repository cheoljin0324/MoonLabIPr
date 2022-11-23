using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCanvasButtonManager : ButtonManager
{
    public void OnSupplyButtonClick()
    {
        Debug.Log("OnSupplyButton");
    }

    public void OnUpgradeButtonClick()
    {
        CanvasManager.Instance.ChangeCanvas("MenuCanvas", "TrainCarUpgradeCanvas");
    }

    public void OnOrganizationButtonClick()
    {
        Debug.Log("OrganizationButton");
    }

    public void OnAchievementButtonClick()
    {
        Debug.Log("AchievementButton");
    }

    public void OnTrainCarListButtonClick()
    {
        CanvasManager.Instance.ChangeCanvas("MenuCanvas", "TrainCarListCanvas");
    }

    public void OnShopButtonClick()
    {
        Debug.Log("OnShopButton");
    }

    public void OnMessageButtonClick()
    {
        Debug.Log("OnMessageButton");
    }

    public void OnSettingButtonClick()
    {
        Debug.Log("OnSettingButton");
    }

    public void OnCalendarButtonClick()
    {
        Debug.Log("OnCalendarButton");
    }
}
