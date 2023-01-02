using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardBase : MonoBehaviour
{
    [SerializeField]
    protected int _moneyReward;
    [SerializeField]
    protected int _mathiasReward;

    public void GivingReward()
    {
        MoneyManager.Instance.AddMoney(_moneyReward);
        MoneyManager.Instance.AddMathias(_mathiasReward);
    }
}
