using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearEvent : Game.Event
{
    protected override void EventContents()
    {
        CombatManager.Instance.Train.TrainMovement.Stop();
        CanvasManager.Instance.ChangeCanvas("CombatCanvas", "ResultCanvas");
    }
}
