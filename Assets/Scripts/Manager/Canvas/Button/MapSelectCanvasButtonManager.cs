using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapSelectCanvasButtonManager : ButtonManager
{
    [SerializeField]
    private MapListSO _mapListSO;

    [SerializeField]
    private Text _countryText;
    [SerializeField]
    private Text _cityText;
    [SerializeField]
    private Text _questDescriptionText;
    [SerializeField]
    private Text _coinRewardValueText;
    [SerializeField]
    private GameObject _coinObject;

    [SerializeField]
    private List<GameObject> _checkMakers = new List<GameObject>();

    private int _index = -1;
    
    public void OnMainMenuButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("MapSelectCanvas", "MenuCanvas");
    }

    public void MapDescriptionChange()
    {
        if (_mapListSO.mapList.Count - 1 < _index) return;

        _coinObject.SetActive(true);
        _countryText.text = _mapListSO.mapList[_index].countryName;
        _cityText.text = _mapListSO.mapList[_index].cityName;
        _questDescriptionText.text = _mapListSO.mapList[_index].questDescription;
        _coinRewardValueText.text = _mapListSO.mapList[_index].coinRewardValue;

        for(int i = 0; i < _checkMakers.Count; i++)
        {
            _checkMakers[i].SetActive(false);
        }
        _checkMakers[_index].SetActive(true);
    }

    public void OnFirstMapButtonClicked()
    {
        _index = 0;
        MapDescriptionChange();
    }

    public void OnSecondMapButtonClicked()
    {
        _index = 1;
        MapDescriptionChange();
    }

    public void OnThirdMapButtonClicked()
    {
        _index = 2;
        MapDescriptionChange();
    }

    public void OnFourthMapButtonClicked()
    {
        _index = 3;
        MapDescriptionChange();
    }

    public void OnFifthMapButtonClicked()
    {
        _index = 4;
        MapDescriptionChange();
    }

    public void OnSixthMapButtonClicked()
    {
        _index = 5;
        MapDescriptionChange();
    }

    public void OnStartButtonClicked()
    {
        if (_index == -1) return;

        LoadingScene.Instance.LoadScene(_mapListSO.mapList[_index].mapName);
        CanvasManager.Instance.ChangeCanvas("MapSelectCanvas", "CombatCanvas");
    }
}
