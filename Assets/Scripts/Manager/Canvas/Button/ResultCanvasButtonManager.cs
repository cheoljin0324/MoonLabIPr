using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultCanvasButtonManager : ButtonManager
{
    [SerializeField]
    private Text _moneyText;
    [SerializeField]
    private Text _mathiasText;

    private Reward _reward;

    private void Start()
    {
        _reward = GetComponent<Reward>();

        _moneyText.text = _moneyText.text + _reward.moneyReward.ToString();
        _mathiasText.text = _mathiasText.text + _reward.mathiasReward.ToString();
    }

    public void OnMainMenuButtonClicked()
    {
        _reward.GivingReward();
        LoadingScene.Instance.LoadScene("MainScene");
        CanvasManager.Instance.ChangeCanvas("ResultCanvas", "MenuCanvas");
    }
}
