using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEvent : Event
{
    [SerializeField]
    private Tank[] _enemyTanks = null;

    [SerializeField]
    private Transform[] _enemyMovePoints = null;

    private uint _enemyCount = 3;
    private bool _isFight = false;

    private IEnumerator Start()
    {
        _enemyTanks[0].TankMovement.MoveTo(_enemyMovePoints[0].position);
        _enemyTanks[1].TankMovement.MoveTo(_enemyMovePoints[1].position);
        _enemyTanks[2].TankMovement.MoveTo(_enemyMovePoints[2].position);

        yield return new WaitForSeconds(6f);

        _enemyTanks[0].Turret.Aim(CombatManager.Instance.Train.TrainCars[5].transform);
        _enemyTanks[1].Turret.Aim(CombatManager.Instance.Train.TrainCars[3].transform);
        _enemyTanks[2].Turret.Aim(CombatManager.Instance.Train.TrainCars[0].transform);

        _isFight = true;

        while (_isFight)
        {
            if (_enemyTanks[0].Turret.IsAiming || _enemyTanks[1].Turret.IsAiming || _enemyTanks[2].Turret.IsAiming)
            {
                yield return null;
                continue;
            }

            _enemyTanks[0]?.Turret?.Fire();
            _enemyTanks[1]?.Turret?.Fire();
            _enemyTanks[2]?.Turret?.Fire();

            yield return new WaitForSeconds(3f);
        }

        TrainCarWeapon[] trainCarWeapon = FindObjectsOfType<TrainCarWeapon>();

        foreach (var weapon in trainCarWeapon)
            weapon.Turret.Release();
    }

    public void OnEnemyTankDestroyed()
    {
        _enemyCount--;

        if (_enemyCount == 0)
        {
            _isFight = false;
            CombatManager.Instance.Train.TrainMovement.Move(10f);
        }
    }

    protected override void EventContents()
    {
        CombatManager.Instance.Train.TrainMovement.Stop();

        var trainCarWeapon = FindObjectsOfType<TrainCarWeapon>();

        foreach (var weapon in trainCarWeapon)
            weapon.OnStartCombat?.Invoke();
    }
}
