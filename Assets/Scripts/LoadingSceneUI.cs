using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingSceneUI : MonoBehaviour
{
    [SerializeField]
    private RectTransform _loadingBar = null;

    private void Start()
    {
        StartCoroutine(RotateLoadingBar());
    }

    private IEnumerator RotateLoadingBar()
    {
        while (true)
        {
            _loadingBar.Rotate(0f, 0f, 0.5f);
            yield return null;
        }
    }
}
