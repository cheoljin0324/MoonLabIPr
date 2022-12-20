using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCarWeapon : MonoBehaviour
{
    [SerializeField]
    private Transform _target = null;

    public System.Action OnStartCombat = null;

    private void Awake()
    {
        OnStartCombat += () => GetComponent<Turret>().Aim(_target);
    }
}
