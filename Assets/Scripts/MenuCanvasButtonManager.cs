using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCanvasButtonManager : ButtonManager
{
    public void OnSupplyButton()
    {
        Debug.Log("OnSupplyButton");
    }

    public void OnEnhanceButton()
    {
        Debug.Log("OnEnhanceButton");
    }

    public void OnOrganizationButton()
    {
        Debug.Log("OrganizationButton");
    }

    public void OnAchievementButton()
    {
        Debug.Log("AchievementButton");
    }

    public void OnTrainCarListButton()
    {
        CanvasManager.Instance.ChangeCanvas("MenuCanvas", "TrainCarListCanvas");
    }

    public void OnShopButton()
    {
        Debug.Log("OnShopButton");
    }

    public void OnMessageButton()
    {
        Debug.Log("OnMessageButton");
    }

    public void OnSettingButton()
    {
        Debug.Log("OnSettingButton");
    }

    public void OnCalendarButton()
    {
        Debug.Log("OnCalendarButton");
    }
}
