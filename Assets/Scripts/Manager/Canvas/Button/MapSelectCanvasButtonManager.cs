using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelectCanvasButtonManager : ButtonManager
{
    public void OnBackButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("MapSelectCanvas", "MenuCanvas");
    }
}
