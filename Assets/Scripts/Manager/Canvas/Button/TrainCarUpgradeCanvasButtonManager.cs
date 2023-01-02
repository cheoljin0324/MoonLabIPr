using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCarUpgradeCanvasButtonManager : ButtonManager
{
    public void OnHomeButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("TrainCarUpgradeCanvas", "MenuCanvas");
    }
    
    //public void OnTrainCarUpgradeButtonClicked()
    //{
    //    Debug.Log("OnTrainCarUpgradeButtonClick");
    //}
}
