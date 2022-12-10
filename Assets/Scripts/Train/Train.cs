using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(TrainMovement))]
[RequireComponent(typeof(TrainRailGenerator))]
public class Train : MonoBehaviour
{
    [SerializeField]
    private TrainCar[] _trainCars = null;
    public TrainCar[] TrainCars => _trainCars;
    
    private TrainMovement _trainMovement = null;
    private TrainRailGenerator _trainRailGenerator = null;

    private void Awake()
    {
        _trainMovement = GetComponent<TrainMovement>();
        _trainRailGenerator = GetComponent<TrainRailGenerator>();
    }
    
    private void Start()
    {
        _trainMovement.Move(150f);
    }

    public Transform[] GetTrainCarTransforms()
    {
        var trainCarTransforms = new Transform[_trainCars.Length];
        for (int i = 0; i < _trainCars.Length; i++)
        {
            trainCarTransforms[i] = _trainCars[i].transform;
        }
        return trainCarTransforms;
    }
}
