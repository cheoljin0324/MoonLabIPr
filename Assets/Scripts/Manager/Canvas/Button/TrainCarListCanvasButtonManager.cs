using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCarListCanvasButtonManager : ButtonManager
{
    public void OnHomeButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("TrainCarListCanvas", "MenuCanvas");
    }
    
    public void OnBookmarkButtonClicked()
    {
        Debug.Log("OnBookmarkButton");
    }
    
    public void OnCommentsButtonClicked()
    {
        Debug.Log("OnCommentsButton");
    }
    
    public void OnLockButtonClicked()
    {
        Debug.Log("OnLockButton");
    }
}
