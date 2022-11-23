using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCarListCanvasButtonManager : ButtonManager
{
    public void OnHomeButtonClick()
    {
        CanvasManager.Instance.ChangeCanvas("TrainCarListCanvas", "MenuCanvas");
    }
    
    public void OnBookmarkButtonClick()
    {
        Debug.Log("OnBookmarkButton");
    }
    
    public void OnCommentsButtonClick()
    {
        Debug.Log("OnCommentsButton");
    }
    
    public void OnLockButtonClick()
    {
        Debug.Log("OnLockButton");
    }
}
