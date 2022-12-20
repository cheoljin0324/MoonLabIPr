using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoSingleton<CombatManager>
{
    private Train _train = null;
    public Train Train => _train;

    protected override void Awake()
    {
        base.Awake();
        _train = FindObjectOfType<Train>();
    }

    private void Start()
    {
        _train.TrainMovement.Move(10f);
    }
}
