using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_MoveMap : Trigger
{
    bool isMove = false;
    public override void EnterTrigger()
    {
        if (isMove) return;
        isMove = true;
        gameObject.transform.parent.Translate(new Vector3(-800f, 0, 0));
        isMove = false;
    }
}
