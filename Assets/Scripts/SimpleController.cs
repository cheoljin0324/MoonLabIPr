using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleController : MonoBehaviour
{
    public KeyCode _objectKey;

    public float _speed;
    
    private bool _isObjectActive = false;

    void Update()
    {
        if(Input.GetKeyDown(_objectKey))
        {
            Debug.Log($"{gameObject.name} is active: {_isObjectActive}");
            _isObjectActive = !_isObjectActive;
        }

        if (_isObjectActive)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.back * _speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.forward * _speed * Time.deltaTime);
            }
        }
    }
}
