using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Serialization;

public class TrainMovement : MonoBehaviour
{
    [FormerlySerializedAs("MaxSpeed")]
    [SerializeField]
    private float _maxSpeed = 1f;

    private bool _isMoving = false;

    private void Awake()
    {
        _isMoving = false;
    }

    public void Move(float speed)
    {
        Debug.Log("Move");
        if (_isMoving)
        {
            StopCoroutine(nameof(MoveCoroutine));
        }

        StartCoroutine(nameof(MoveCoroutine), speed);
    }

    public void Move()
    {
        if (_isMoving)
        {
            StopCoroutine(nameof(MoveCoroutine));
        }

        StartCoroutine(nameof(MoveCoroutine), _maxSpeed);
    }

    public void Stop()
    {
        _isMoving = false;
        GetComponent<TrainAnimation>().PlayStopAnimation();
    }

    public IEnumerator MoveCoroutine(float speed)
    {
        _isMoving = true;

        float trainSpeed = Mathf.Clamp(speed, 0f, _maxSpeed);

        GetComponent<TrainAnimation>().PlayMoveAnimation();

        while (_isMoving)
        {
            transform.Translate(Vector3.forward * trainSpeed * Time.deltaTime);
            Debug.Log("Moving");
            yield return null;
        }

        _isMoving = false;
    }
}
