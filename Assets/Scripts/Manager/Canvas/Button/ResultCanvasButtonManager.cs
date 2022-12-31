using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ResultCanvasButtonManager : ButtonManager
{
    [SerializeField]
    private GameObject _stageUIObject;
    [SerializeField]
    private GameObject _killUIObject;
    [SerializeField]
    private GameObject _moneyUIObject;

    private Vector3 _stageUIOriginPos;
    private Vector3 _killUIOriginPos;
    private Vector3 _moneyUIOriginPos;

    private void Start()
    {
        _stageUIOriginPos = _stageUIObject.transform.position;
        _killUIOriginPos = _killUIObject.transform.position;
        _moneyUIOriginPos = _moneyUIObject.transform.position;
    }

    public void OnMainMenuButtonClicked()
    {
        LoadingScene.Instance.LoadScene("MainScene");
        CanvasManager.Instance.ChangeCanvas("ResultCanvas", "MenuCanvas");
    }

    public void ResultUIDownMove()
    {
        _stageUIObject.transform.Translate(new Vector2(0f, 800f));
        _killUIObject.transform.Translate(new Vector2(0f, 800f));
        _moneyUIObject.transform.Translate(new Vector2(0f, 800f));

        _stageUIObject.transform.DOMoveY(_stageUIOriginPos.y, 2f);
        _killUIObject.transform.DOMoveY(_killUIOriginPos.y, 2f);
        _moneyUIObject.transform.DOMoveY(_moneyUIOriginPos.y, 2f);
    }
}
