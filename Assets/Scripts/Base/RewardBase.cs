using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardBase : MonoBehaviour
{
    [SerializeField]
    public int moneyReward;
    [SerializeField]
    public int mathiasReward;

    public void GivingReward()
    {
        MoneyManager.Instance.AddMoney(moneyReward);
        MoneyManager.Instance.AddMathias(mathiasReward);
    }
}
