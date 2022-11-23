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
        Debug.Log("10");
    }
    
    public void OnGachaButton1Clicked()
    {
        Debug.Log("1");
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
