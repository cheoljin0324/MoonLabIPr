using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TrainCarStat
{
    public int atk = 0;
    public float atkSpeed = 0;
    public int heavy = 0;
    public uint maxHp = 0;
    public float shotSpeed = 0;
    public float skillCoolTime = 0;
    public int skillDamage = 0;

    public TrainCarStat()
    {
        atk = 0;
        atkSpeed = 0;
        heavy = 0;
        maxHp = 0;
        shotSpeed = 0;
        skillCoolTime = 0;
        skillDamage = 0;
    }

    public TrainCarStat(int atk, float atkSpeed, int heavy, uint maxHp, float shotSpeed, float skillCoolTime, int skillDamage)
    {
        this.atk = atk;
        this.atkSpeed = atkSpeed;
        this.heavy = heavy;
        this.maxHp = maxHp;
        this.shotSpeed = shotSpeed;
        this.skillCoolTime = skillCoolTime;
        this.skillDamage = skillDamage;
    }
}
