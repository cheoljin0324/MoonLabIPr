using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCarWeapon : MonoBehaviour
{
    [SerializeField]
    private Transform _target = null;

    private Turret _turret = null;

    public System.Action OnStartCombat = null;

    private void Awake()
    {
        _turret = GetComponent<Turret>();
        OnStartCombat += () => _turret.Aim(_target);
        OnStartCombat += () => StartCoroutine(nameof(FireStart));
    }

    private IEnumerator FireStart()
    {
        while (true)
        {
            if (_turret.IsAiming)
            {
                yield return null;
                continue;
            }

            _turret.Fire();
            yield return new WaitForSeconds(3f);
        }
    }
}
