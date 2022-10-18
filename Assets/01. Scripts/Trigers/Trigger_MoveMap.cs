using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_MoveMap : Trigger
{
    public override void EnterTrigger()
    {
        gameObject.transform.parent.Translate(new Vector3(-800f, 0, 0));
    }
}
