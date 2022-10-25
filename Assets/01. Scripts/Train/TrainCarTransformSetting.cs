using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCarTransformSetting : MonoBehaviour
{
    [Tooltip("Gap between train cars")]
    [SerializeField]
    private float _interval = 0.5f;

    private Train _train = null;


    private void Start()
    {
        _train = GetComponent<Train>();
        SetTransform();
    }

    public void SetTransform()
    {
        for (int i = 0; i < _train.TrainCarCount; i++)
        {
            _train.TrainCarsTransformList[i].position = transform.position + new Vector3(-((_train.TrainCarsTransformList[i].localScale.x + _interval) * i), _train.TrainCarsTransformList[i].localScale.y / 2, transform.position.z);
        }
    }
}
