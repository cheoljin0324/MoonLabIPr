using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCarImage : MonoBehaviour
{
    public bool isIn = false;

    private void OnMouseEnter()
    {
        isIn = true;
    }

    private void OnMouseExit()
    {
        isIn = false;
    }
}
