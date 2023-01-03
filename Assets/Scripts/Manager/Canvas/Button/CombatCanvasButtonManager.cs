using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCanvasButtonManager : ButtonManager
{
    public void OnMenuButtonClicked()
    {
        // 메뉴 Canvas 나오게해야함
        // 게임 진행상황 일시중지
    }

    public void OnSkill1ButtonClicked()
    {
        SkillManager.Instance.ThunderSkill();
    }

    public void OnFirstCameraButtonClicked()
    {
        Camera.main.GetComponent<CameraController>().MoveTrainCar(0);
    }

    public void OnSecondCameraButtonClicked()
    {
        Camera.main.GetComponent<CameraController>().MoveTrainCar(1);
    }

    public void OnThirdCameraButtonClicked()
    {
        Camera.main.GetComponent<CameraController>().MoveTrainCar(2);
    }

    public void OnFourthCameraButtonClicked()
    {
        Camera.main.GetComponent<CameraController>().MoveTrainCar(3);
    }

    public void OnFifthCameraButtonClicked()
    {
        Camera.main.GetComponent<CameraController>().MoveTrainCar(4);
    }

    public void OnSixthCameraButtonClicked()
    {
        Camera.main.GetComponent<CameraController>().MoveTrainCar(5);
    }
}
