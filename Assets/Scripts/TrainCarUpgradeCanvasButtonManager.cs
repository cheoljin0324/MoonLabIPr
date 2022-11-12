using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCarUpgradeCanvasButtonManager : ButtonManager
{
    public void OnHomeButtonClick()
    {
        CanvasManager.Instance.ChangeCanvas("TrainCarUpgradeCanvas", "MenuCanvas");
    }
}
