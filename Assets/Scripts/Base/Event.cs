using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Event : MonoBehaviour
{
    protected abstract void EventContents();
    
    public void StartEvent()
    {
        EventContents();
    }

    private void Awake()
    {
        if (!gameObject.CompareTag("Event"))
        {
            gameObject.tag = "Event";
        }
    }
}
