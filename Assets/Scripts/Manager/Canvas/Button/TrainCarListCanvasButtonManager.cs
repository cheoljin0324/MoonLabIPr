using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainCarListCanvasButtonManager : ButtonManager
{
    [SerializeField]
    private Text _moneyText;
    [SerializeField]
    private Text _mathiasText;

    private void Start()
    {
        _moneyText.text = PlayerPrefs.GetInt("Money").ToString();
        _mathiasText.text = PlayerPrefs.GetInt("Mathias").ToString();
    }
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
