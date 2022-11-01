using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Skill
{
    ATK,
    DEBUFF,
    CC
}

public class Train : MonoBehaviour
{
    private List<Transform> _trainCarsTransformList = null;
    public List<Transform> TrainCarsTransformList => _trainCarsTransformList;

    private uint _trainCarCount;
    public uint TrainCarCount => _trainCarCount;

    public Skill _skill;

    private void Awake()
    {
        _trainCarsTransformList = new List<Transform>();
        _trainCarCount = (uint)transform.childCount;

        for (int i = 0; i < _trainCarCount; ++i)
        {
            _trainCarsTransformList.Add(transform.GetChild(i));
        }

        if (_trainCarCount != _trainCarsTransformList.Count)
        {
            Debug.LogError($"TrainCarTransformSetting: TrainCarCount is not equal to TrainCarTransforms.Length\n_trainCarCount: {_trainCarCount}\n_trainCarsTransformList.Count: {_trainCarsTransformList.Count}");
        }

        foreach (var trainCarTransform in _trainCarsTransformList)
        {
            trainCarTransform.gameObject.AddComponent<TrainCar>();
        }
    }
}
