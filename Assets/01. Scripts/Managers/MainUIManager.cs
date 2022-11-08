using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MainUIManager : Singleton<MainUIManager>
{
    private Canvas openCanvas = null;

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
            openCanvas.renderMode = RenderMode.WorldSpace;
            originScale = openCanvas.transform.localScale;
            openCanvas.transform.localScale = startScale;
            openCanvas.enabled = true;
            DOTween.Sequence()
                .Append(openCanvas.transform.DOScale(originScale, 0.2f))
                .AppendInterval(0.2f)
                .OnComplete(() =>
                {
                    openCanvas.renderMode = RenderMode.ScreenSpaceCamera;
                });
            
        }
    }

    public void OpenDownUI(GameObject ui)
    {
        openCanvas = ui.GetComponent<Canvas>();
        if (openCanvas != null)
        {
            openCanvas.renderMode = RenderMode.WorldSpace;
            openCanvas.transform.position += startPos;
            openCanvas.enabled = true;
            DOTween.Sequence()
                .Append(openCanvas.transform.DOMoveY(originYPos, 0.3f))
                .AppendInterval(0.3f)
                .OnComplete(() =>
                {
                    openCanvas.renderMode = RenderMode.ScreenSpaceCamera;
                });

        }
    }
}
