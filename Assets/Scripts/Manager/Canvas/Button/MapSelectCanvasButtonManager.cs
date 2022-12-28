using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapSelectCanvasButtonManager : ButtonManager
{
    public MapListSO mapListSO;

    public Text country;
    public Text station;
    public Text questDiscription;
    public Text missionReward;

    public void OnBackButtonClicked()
    {
        CanvasManager.Instance.ChangeCanvas("MapSelectCanvas", "MenuCanvas");
    }

    public void OnMap1ButtonClicked()
    {
        country.text = mapListSO.mapList[0].countryName;
        station.text = mapListSO.mapList[0].stationName;
        questDiscription.text = mapListSO.mapList[0].questDiscription;
        missionReward.text = mapListSO.mapList[0].missionReward;
    }

    public void OnMap2ButtonClicked()
    {
        country.text = mapListSO.mapList[1].countryName;
        station.text = mapListSO.mapList[1].stationName;
        questDiscription.text = mapListSO.mapList[1].questDiscription;
        missionReward.text = mapListSO.mapList[1].missionReward;
    }

    public void OnGameStartButtonClicked()
    {
        LoadingScene.Instance.LoadScene("WinterCombatScene");
        CanvasManager.Instance.ChangeCanvas("MapSelectCanvas", "CombatCanvas");
    }
}
