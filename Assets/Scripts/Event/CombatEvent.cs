using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CombatEvent : Game.Event
{
    [SerializeField]
    private List<Tank> _enemyTanks = null;

    [SerializeField]
    private Transform[] _enemyMovePoints = null;

    private uint _enemyCount = 3;
    private bool _isFight = false;

    private IEnumerator Start()
    {
        _enemyCount = (uint)_enemyTanks.Count;

        for (int i = 0; i < _enemyCount; ++i)
        {
            _enemyTanks[i].OnTankDestroyed += OnEnemyTankDestroyed;
            _enemyTanks[i].TankMovement.MoveTo(_enemyMovePoints[i].position);
        }

        yield return new WaitForSeconds(6f);

        for (int i = 0; i < _enemyCount; ++i)
        {
            _enemyTanks[i].Turret.Aim(CombatManager.Instance.Train.TrainCars[(5 - (i * 2)) == 1 ? 0 : (5 - (i * 2))].transform);
        }

        _isFight = true;

        while (_isFight)
        {
            foreach (var tank in _enemyTanks)
            {
                if (tank.Turret.IsAiming)
                {
                    yield return null;
                    continue;
                }
                tank.Turret.Fire();
            }

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
        {
            weapon.OnStartCombat?.Invoke();
        }
    }
}
