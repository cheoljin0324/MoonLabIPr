using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class TrainMove : MonoBehaviour
{
    private TrainStat _trainStat = null;

    private bool _isMoving = false;

    private void Awake()
    {
        _trainStat = GetComponent<TrainStat>();
        _isMoving = false;
    }

    /// <summary>
    /// Test function to move the train
    /// </summary>
    [ContextMenu("Move")]
    public void Move()
    {
        Move(1f);
    }
    
    public void Move(float speed)
    {
        if (_isMoving)
        {
            StopCoroutine(nameof(MoveCoroutine));    
        }
        
        StartCoroutine(nameof(MoveCoroutine), 1);
    }

    public void Stop()
    {
        _isMoving = false;
    }
    
    private IEnumerator MoveCoroutine(float speed)
    {
        _isMoving = true;

        float trainSpeed = Mathf.Clamp(speed, -_trainStat.MaxSpeed, _trainStat.MaxSpeed);
        
        while (_isMoving)
        {
            transform.Translate(Vector3.forward * trainSpeed * Time.deltaTime);
            yield return null;
        }

        _isMoving = false;
    }
}
