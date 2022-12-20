using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEvent : Event
{
    [SerializeField]
    private Tank[] _enemyTanks = null;

    [SerializeField]
    private Transform[] _enemyMovePoints = null;

    private IEnumerator Start()
    {
        _enemyTanks[0].TankMovement.MoveTo(_enemyMovePoints[0].position);
        _enemyTanks[1].TankMovement.MoveTo(_enemyMovePoints[1].position);
        _enemyTanks[2].TankMovement.MoveTo(_enemyMovePoints[2].position);

        yield return new WaitForSeconds(6f);

        _enemyTanks[0].Turret.Aim(CombatManager.Instance.Train.TrainCars[5].transform);
        _enemyTanks[1].Turret.Aim(CombatManager.Instance.Train.TrainCars[3].transform);
        _enemyTanks[2].Turret.Aim(CombatManager.Instance.Train.TrainCars[0].transform);
    }

    protected override void EventContents()
    {
        CombatManager.Instance.Train.TrainMovement.Stop();

        var trainCarWeapon = FindObjectsOfType<TrainCarWeapon>();

        foreach (var weapon in trainCarWeapon)
            weapon.OnStartCombat?.Invoke();


    }
}
