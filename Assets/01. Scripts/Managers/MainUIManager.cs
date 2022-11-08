using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MainUIManager : Singleton<MainUIManager>
{
    private Canvas openCanvas;

    private Vector3 startScale = Vector3.zero;
    private Vector3 originScale;

    private Vector3 startPos = new Vector3(0f, 2f, 0f);
    private float originYPos = 1f;

    public Text nameText;
    public UserNameSO _userNameSO;

    public void UpdateText()
    {
        nameText.text = _userNameSO.name;
    }

    public void OpenBiggerUI(GameObject ui)
    {
        openCanvas = ui.GetComponent<Canvas>();
        if (openCanvas != null)
        {
            originScale = ui.transform.localScale;
            ui.transform.localScale = startScale;
            openCanvas.enabled = true;
            ui.transform.DOScale(originScale, 0.2f);
        }
    }

    public void OpenDownUI(GameObject ui)
    {
        openCanvas = ui.GetComponent<Canvas>();
        if (openCanvas != null)
        {
            ui.transform.position += startPos;
            openCanvas.enabled = true;
            ui.transform.DOMoveY(originYPos, 0.3f);
        }
    }
}
