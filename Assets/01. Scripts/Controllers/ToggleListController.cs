using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleListController : MonoBehaviour
{
    [SerializeField]
    private Toggle[] toggles = null;

    [SerializeField]
    private GameObject[] contentList = null;

    private uint currentContentIndex = 0;

    void Start()
    {
        if (toggles.Length != contentList.Length || toggles.Length == 0)
        {
            Debug.LogError("ToggleListController: Toggles and content list must have the same length and must be greater than 0");
            return;
        }
        Initialization();
    }

    private void Initialization()
    {
        for (int i = 0; i < toggles.Length; i++)
        {
            toggles[i].onValueChanged.AddListener((bool value) => OnToggleValueChanged(value));
        }
        toggles[0].isOn = true;
    }

    private void OnToggleValueChanged(bool value)
    {
        if (!value)
        {
            toggles[currentContentIndex].isOn = true;
            return;
        }

        for (int i = 0; i < toggles.Length; ++i)
        {
            if (toggles[i].isOn)
            {
                currentContentIndex = (uint)i;
            }
            else
            {
                toggles[i].isOn = false;
            }
        }
    }
}
