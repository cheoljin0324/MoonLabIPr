using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour
{
    private void Start()
    {
        InvokeRepeating("CheckTrigger", 0f, 0.5f);
    }
    private void CheckTrigger()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, 50f);

        for (int i = 0; i < cols.Length; i++)
        {
            cols[i].GetComponent<Trigger>()?.EnterTrigger();
        }
    }
}
