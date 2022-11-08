using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MainUIManager : Singleton<MainUIManager>
{
    private Vector3 startScale = Vector3.zero;
    private Vector3 originScale;
    private Canvas openCanvas;

    public Text nameText;
    public UserNameSO _userNameSO;

    public void UpdateText()
    {
        nameText.text = _userNameSO.name;
    }

    public void OpenUI(GameObject ui)
    {
        openCanvas = ui.GetComponent<Canvas>();
        if (openCanvas != null)
        {
            openCanvas.renderMode = RenderMode.WorldSpace;
            originScale = ui.transform.localScale;
            ui.transform.localScale = startScale;
            openCanvas.enabled = true;
            ui.transform.DOScale(originScale, 0.5f);
        }
    }
}
