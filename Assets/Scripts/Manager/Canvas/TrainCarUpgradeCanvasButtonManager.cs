using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCarUpgradeCanvasButtonManager : ButtonManager
{
    public void OnBackButtonClick()
    {
        CanvasManager.Instance.ChangeCanvas("TrainCarUpgradeCanvas", "MenuCanvas");
    }
    
    public void OnTrainCarUpgradeButtonClick()
    {
        Debug.Log("OnTrainCarUpgradeButtonClick");
    }
}
