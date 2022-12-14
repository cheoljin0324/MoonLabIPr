using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// 해당 맵에 대한 정보
[Serializable]
public class Map
{
    public string countryName;
    public string stationName;
    public string questDiscription;
    public string missionReward;
}

[CreateAssetMenu(menuName = "SO/Data/MapList")]
public class MapListSO : ScriptableObject
{
    public List<Map> mapList;
}
