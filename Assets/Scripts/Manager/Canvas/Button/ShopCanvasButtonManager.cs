using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ShopCanvasButtonManager : ButtonManager
{
    public void OnExitButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("ShopCanvas", "MenuCanvas");
    }
}
