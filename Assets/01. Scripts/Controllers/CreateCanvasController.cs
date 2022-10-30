using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateCanvasController : MonoBehaviour
{
    public Button _leftButton;
    public Button _rightButton;
    public GameObject _content;

    public Text _text;

    private List<GameObject> _contents = new List<GameObject>();

    private uint _currentTrainCarIndex = 0;

    void Start()
    {
        _leftButton.onClick.AddListener(() =>
        {
            if (_currentTrainCarIndex > 0)
            {
                _currentTrainCarIndex--;
                _text.text = _currentTrainCarIndex.ToString();
            }
        });

        _rightButton.onClick.AddListener(() =>
        {
            _currentTrainCarIndex++;
            _text.text = _currentTrainCarIndex.ToString();
        });

        foreach (Transform content in _content.transform)
        {
            _contents.Add(content.gameObject);
        }


    }
}
