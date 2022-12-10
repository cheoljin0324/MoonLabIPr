using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCollisionEventTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Event":
                other.GetComponent<Event>().StartEvent();
                break;
        }
    }
}
