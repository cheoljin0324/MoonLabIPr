using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementCanvasButtonManager : ButtonManager
{
    public void OnExitButtonClicked()
    {
        // 사라질 수도 있는 캔버스
        CanvasManager.Instance.ChangeCanvas("AchievementCanvas", "MenuCanvas");
    }
}
