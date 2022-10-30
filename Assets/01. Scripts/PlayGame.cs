using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneController.Instance.LoadScene("PlayScene");
    }
}
