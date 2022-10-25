using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Train SO", menuName = "Train Car")]
public class TrainCarSO : ScriptableObject
{
    public Rank Rank = Rank.None;
    public TrainCarType Type = TrainCarType.None;
    public TrainStat Stat = null;
    public GameObject Model = null;
    public Vector3 ModelSize = Vector3.zero;
}
