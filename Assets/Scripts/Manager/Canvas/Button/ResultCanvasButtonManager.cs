using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultCanvasButtonManager : ButtonManager
{
    public void OnMainMenuButtonClicked()
    {
        SceneManager.LoadScene("MainScene");
        CanvasManager.Instance.ChangeCanvas("ResultCanvas", "MenuCanvas");
    }
}
