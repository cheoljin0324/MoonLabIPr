using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganizationCanvasButtonManager : ButtonManager
{
    public void OnHomeButtonClicked()
    {
        // 사라질 수도 잇는 함수
        CanvasManager.Instance.ChangeCanvas("OrganizationCanvas", "MenuCanvas");
    }
}
