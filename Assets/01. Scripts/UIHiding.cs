using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;

public class UIHiding : MonoBehaviour
{
    private bool isHiding = false;

    public List<GameObject> rightButtons = new List<GameObject>();
    public List<GameObject> leftButtons = new List<GameObject>();
    public GameObject uiHideButton;

    public Transform rightPos;
    public Transform leftPos;
    public List<Transform> uiHideButtonPos = new List<Transform>();
    private List<Vector3> rightOriginPos = new List<Vector3>();
    private List<Vector3> leftOriginPos = new List<Vector3>();

    private void Start()
    {
        for (int i = 0; i < rightButtons.Count; i++)
        {
            rightOriginPos.Add(rightButtons[i].transform.position);
        }
        for (int i = 0; i < leftButtons.Count; i++)
        {
            leftOriginPos.Add(leftButtons[i].transform.position);
        }
    }

    public void OnHideUI()
    {
        if (isHiding == false)
        {
            isHiding = true;
            foreach (GameObject rightUI in rightButtons)
            {
                rightUI.transform.DOMoveX(rightPos.position.x, 1f);
            }
            foreach (GameObject leftUI in leftButtons)
            {
                leftUI.transform.DOMoveX(leftPos.position.x, 1f);
            }
            uiHideButton.transform.DOMoveX(uiHideButtonPos[0].position.x, 1f);
        }

        else if (isHiding == true)
        {
            isHiding = false;
            int l = 0, r = 0;
            foreach (GameObject rightUI in rightButtons)
            {
                rightUI.transform.DOMoveX(rightOriginPos[r++].x, 1f);
            }
            foreach (GameObject leftUI in leftButtons)
            {
                leftUI.transform.DOMoveX(leftOriginPos[l++].x, 1f);
            }
            uiHideButton.transform.DOMoveX(uiHideButtonPos[1].position.x, 1f);
        }
    }
}
