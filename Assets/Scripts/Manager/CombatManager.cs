using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatManager : MonoSingleton<CombatManager>
{
    private Train _train = null;
    public Train Train => _train;

    [SerializeField]
    private Slider _distanceSlider = null;

    [SerializeField]
    private Transform _goalTransform = null;

    private Vector3 _startPosition = Vector3.zero;

    protected override void Awake()
    {
        base.Awake();
        _train = FindObjectOfType<Train>();
        _startPosition = new Vector3(_train.transform.position.x, _train.transform.position.y, _train.transform.position.z);
    }

    private void Update()
    {
        _distanceSlider.value = (Vector3.Distance(_train.transform.position, _goalTransform.position) / Vector3.Distance(_startPosition, _goalTransform.position) >= 0.02f) ? Vector3.Distance(_train.transform.position, _goalTransform.position) / Vector3.Distance(_startPosition, _goalTransform.position) : 0f;
    }
}
