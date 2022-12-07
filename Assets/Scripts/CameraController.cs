 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Range(0f, 1f)]
    [SerializeField]
    private float _sensitivity = 1f;
    
    [SerializeField]
    private Transform _target = null;

    [SerializeField] 
    private Vector3 _offset = Vector3.zero;
    
    [SerializeField]
    private Vector3 _rotation = Vector3.zero;
    
    private Vector3 _moveVector = Vector3.zero;

    private Vector2 _clickPosition = Vector2.zero;
    private Vector2 _beforePosition = Vector2.zero;
    
    private bool _isClicking = false;
    private bool _isMove = false;

    private void Start()
    {
        transform.position = _target.position + _offset;
        transform.rotation = Quaternion.Euler(_rotation);
        
        _moveVector = _offset;
        
        _clickPosition = Vector2.zero;
        _beforePosition = Vector2.zero;
        
        _isClicking = false;
        _isMove = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _clickPosition = Input.mousePosition;
            _isClicking = true;
        }

        _isMove = (Vector2.Distance(Input.mousePosition, _beforePosition) > 0f) && _isClicking;
        _beforePosition = Input.mousePosition;
        
        if (Input.GetMouseButtonUp(0))
        {
            _clickPosition = Vector2.zero;
            _isClicking = false;
        }
    }

    private void LateUpdate()
    {
        if (_isMove)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z + (_clickPosition.x - Input.mousePosition.x)), _sensitivity * Time.deltaTime);
            _moveVector = transform.position - _target.position;
        }
        else if(!_isClicking)
        {
            transform.position = _target.position + _moveVector;
        }

        transform.position = new Vector3(transform.position.x, transform.position.y,Mathf.Clamp(transform.position.z, _target.transform.position.z - 50f, _target.transform.position.z));
    }
}
