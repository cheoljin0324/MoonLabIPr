using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ShopCanvasButtonManager : ButtonManager
{
    public void OnCloseButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("ShopCanvas", "MenuCanvas");
    }
    
    public void OnGachaButton10Clicked()
    {
        CanvasManager.Instance.ChangeCanvas("ShopCanvas", "Gacha10Canvas");
    }
    
    public void OnGachaButton1Clicked()
    {
        CanvasManager.Instance.ChangeCanvas("ShopCanvas", "GachaCanvas");
    }

    public void OnAppearCharacterButtonClicked()
    {
        Debug.Log("Appear");
    }
    
    public void OnRouletteLogButtonClicked()
    {
        Debug.Log("RouletteLog");
    }
}
