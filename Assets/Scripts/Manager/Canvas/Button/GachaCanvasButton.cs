using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaCanvasButton : ButtonManager
{
    public void OnCloseButtonClick()
    {
        CanvasManager.Instance.ChangeCanvas("GachaCanvas", "ShopCanvas");
    }


}
