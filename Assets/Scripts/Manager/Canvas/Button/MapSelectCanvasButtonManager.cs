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

    private int _index;

    public void OnMainMenuButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("MapSelectCanvas", "MenuCanvas");
    }

    public void MapDescriptionChange()
    {
        if (_mapListSO.mapList.Count - 1 < _index) return;

        _countryText.text = _mapListSO.mapList[_index].countryName;
        _cityText.text = _mapListSO.mapList[_index].cityName;
        _questDescriptionText.text = _mapListSO.mapList[_index].questDescription;
        _coinRewardValueText.text = _mapListSO.mapList[_index].coinRewardValue;
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

    public void OnStartButtonClicked()
    {
        LoadingScene.Instance.LoadScene(_mapListSO.mapList[_index].mapName);
        CanvasManager.Instance.ChangeCanvas("MapSelectCanvas", "CombatCanvas");
    }
}
