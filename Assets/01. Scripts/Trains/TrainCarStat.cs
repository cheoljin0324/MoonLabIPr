using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class TrainCarStat
{
    [SerializeField]
    private int _atk = 0;
    public int Atk => _atk;

    [SerializeField]
    private float _atkSpeed = 0;
    public float AtkSpeed => _atkSpeed;

    [SerializeField]
    private float _heavy = 0;
    public float Heavy => _heavy;

    [SerializeField]
    private uint _health = 0;
    public uint Health => _health;
}
