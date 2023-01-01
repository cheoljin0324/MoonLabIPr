using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// �ش� �ʿ� ���� ����
[Serializable]
public class Map
{
    public string countryName;
    public string cityName;
    public string questDescription;
    public string coinRewardValue;
    public string mapName;
}

[CreateAssetMenu(menuName = "SO/Data/MapList")]
public class MapListSO : ScriptableObject
{
    public List<Map> mapList;
}
