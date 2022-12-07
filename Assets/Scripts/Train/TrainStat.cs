using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainStat : MonoBehaviour
{
    [SerializeField]
    private float _maxSpeed = 0.0f;

    public float MaxSpeed => _maxSpeed;
}
