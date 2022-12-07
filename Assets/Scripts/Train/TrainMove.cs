using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class TrainMove : MonoBehaviour
{
    [SerializeField] 
    private float MaxSpeed = 1f;

    private bool _isMoving = false;

    private void Awake()
    {
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

        float trainSpeed = Mathf.Clamp(speed, 0f, MaxSpeed);
        
        while (_isMoving)
        {
            transform.Translate(Vector3.forward * trainSpeed * Time.deltaTime);
            yield return null;
        }

        _isMoving = false;
    }
}
