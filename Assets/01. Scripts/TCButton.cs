using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TCButton : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private Vector2 _startPos;
    private Vector2 _endPos;

    public TrainCarImage _trainCarImage;

    private bool _isDrag = false;

    public void OnDrag(PointerEventData eventData)
    {
        _isDrag = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _startPos = eventData.position;
        StartCoroutine(CheckDrag());
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (_isDrag == true && _trainCarImage.isIn == true)
        {
            _trainCarImage.gameObject.GetComponent<Image>().color = gameObject.GetComponent<Image>().color;
        }
    }

    private IEnumerator CheckDrag()
    {
        yield return new WaitForSeconds(0.5f);
        if (_isDrag == false)
        {
            Debug.Log("대충 열차칸 정보");
        }
    }
}
