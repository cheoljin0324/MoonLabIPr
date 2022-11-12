using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCarListCanvasButtonManager : ButtonManager
{
    public void OnHomeButton()
    {
        CanvasManager.Instance.ChangeCanvas("TrainCarListCanvas", "MenuCanvas");
    }
    
    public void OnBookmarkButton()
    {
        Debug.Log("OnBookmarkButton");
    }
    
    public void OnCommentsButton()
    {
        Debug.Log("OnCommentsButton");
    }
    
    public void OnLockButton()
    {
        Debug.Log("OnLockButton");
    }
}
