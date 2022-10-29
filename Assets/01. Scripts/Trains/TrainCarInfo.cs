using System.Security.AccessControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCarInfo
{
    public string id = string.Empty;

    public string name = string.Empty;

    public int atk = 0;
    public float atkSpeed = 0;
    public int heavy = 0;
    public uint health = 0;
    public float shotSpeed = 0;
    public float skillCool = 0;
    public int skillDamage = 0;

    public string rank;

    public string type;

    public string skillType;

    public string skillAimType;

    public bool playerUse = true;
}
