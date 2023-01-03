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

    }

    public void OnSecondCameraButtonClicked()
    {
        Camera.main.GetComponent<CameraController>().MoveTrainCar(1);
    }

    public void OnThirdCameraButtonClicked()
    {
        _xPos = CombatManager.Instance.Train.TrainCars[2].gameObject.transform.position.x;
        Camera.main.transform.position = new Vector3(_xPos, Camera.main.transform.position.y, Camera.main.transform.position.z);
    }

    public void OnFourthCameraButtonClicked()
    {
        _xPos = CombatManager.Instance.Train.TrainCars[3].gameObject.transform.position.x;
        Camera.main.transform.position = new Vector3(_xPos, Camera.main.transform.position.y, Camera.main.transform.position.z);
    }

    public void OnFifthCameraButtonClicked()
    {
        _xPos = CombatManager.Instance.Train.TrainCars[4].gameObject.transform.position.x;
        Camera.main.transform.position = new Vector3(_xPos, Camera.main.transform.position.y, Camera.main.transform.position.z);
    }

    public void OnSixthCameraButtonClicked()
    {
        _xPos = CombatManager.Instance.Train.TrainCars[5].gameObject.transform.position.x;
        Camera.main.transform.position = new Vector3(_xPos, Camera.main.transform.position.y, Camera.main.transform.position.z);
    }
}
