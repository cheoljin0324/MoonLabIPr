using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoSingleton<MoneyManager>
{
    private int _money = 0;
    private int _mathias = 0;

    public int Money
    {
        get
        {
            return _money;
        }
    }
    
    public int Mathias
    {
        get
        {
            return _mathias;
        }
    }

    private void Start()
    {
        _money = PlayerPrefs.GetInt("Money");
        _mathias = PlayerPrefs.GetInt("Mathias");
    }
    
    public void AddMoney(int amount)
    {
        _money += amount;
        PlayerPrefs.SetInt("Money", _money);
    }
    
    public void AddMathias(int amount)
    {
        _mathias += amount;
        PlayerPrefs.SetInt("Mathias", _mathias);
    }
}
