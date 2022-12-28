using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingUIAnimation : MonoBehaviour
{
    [SerializeField]
    private Sprite[] animationImage = null;

    [SerializeField]
    private float animationSpeed = 0.1f;

    private Image _image = null;

    private uint _currentImageIndex = 0;

    private void Start()
    {
        _image = GetComponent<Image>();
        StartCoroutine(LoadingTextAnimation());
    }

    private IEnumerator LoadingTextAnimation()
    {
        while (true)
        {
            _image.sprite = animationImage[_currentImageIndex];
            _currentImageIndex = (_currentImageIndex + 1) % (uint)animationImage.Length;
            _image.SetNativeSize();

            (transform as RectTransform).sizeDelta /= 1.2f;

            yield return new WaitForSeconds(animationSpeed);
        }
    }
}
