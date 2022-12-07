using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
}
