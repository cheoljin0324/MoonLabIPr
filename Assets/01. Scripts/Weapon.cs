using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float fireRate = 0.5f;
    private float nextFire = 0.0f;

    private GameObject target;
    private Transform _transform;

    private void Start()
    {
        _transform = transform.GetChild(0);
    }

    private void Update()
    {
        if (target == null)
        {
            Collider[] colliders = Physics.OverlapSphere(_transform.position, 20.0f);
            foreach (Collider collider in colliders)
            {
                if (collider.GetComponent<Enemy>() != null)
                {
                    target = collider.gameObject;
                    break;
                }
            }
        }
        else
        {
            // 여기 부분 질문해보기
            _transform.rotation = Quaternion.Slerp(_transform.rotation, Quaternion.LookRotation(target.transform.position - _transform.position), Time.deltaTime * 5.0f);
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;

                Vector3 fireAngle = target.transform.position - _transform.position;

                GameObject bullet = Instantiate(bulletPrefab, _transform.position, Quaternion.LookRotation(fireAngle));

                Destroy(bullet, 4.0f);
            }
        }
    }
}
