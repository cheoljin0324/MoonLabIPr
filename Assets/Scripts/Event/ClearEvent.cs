using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearEvent : Event
{
    protected override void EventContents()
    {
        CombatManager.Instance.Train.TrainMovement.Stop();
        Debug.Log("Clear");
    }
}
