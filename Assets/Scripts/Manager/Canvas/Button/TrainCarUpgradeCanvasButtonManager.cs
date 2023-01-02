using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainCarUpgradeCanvasButtonManager : ButtonManager
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
        CanvasManager.Instance.ChangeCanvas("TrainCarUpgradeCanvas", "MenuCanvas");
    }
    
    //public void OnTrainCarUpgradeButtonClicked()
    //{
    //    Debug.Log("OnTrainCarUpgradeButtonClick");
    //}
}
