using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEvent : Event
{
    protected override void EventContents()
    {
        CombatManager.Instance.Train.TrainMovement.Stop();
    }
}
