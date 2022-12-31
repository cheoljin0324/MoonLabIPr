using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoSingleton<MoneyManager>
{
    private int _money = 0;
    private int _jewels = 0;

    public int Money
    {
        get
        {
            return _money;
        }
    }
    
    public int Jewels
    {
        get
        {
            return _jewels;
        }
    }

    private void Start()
    {
        _money = PlayerPrefs.GetInt("Money");
        _jewels = PlayerPrefs.GetInt("Jewels");
    }
    
    public void AddMoney(int amount)
    {
        _money += amount;
        PlayerPrefs.SetInt("Money", _money);
    }
    
    public void AddJewels(int amount)
    {
        _jewels += amount;
        PlayerPrefs.SetInt("Jewels", _jewels);
    }
}
