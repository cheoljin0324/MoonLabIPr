using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCanvasButtonManager : ButtonManager
{
    private float _xPos;

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
        _xPos = CombatManager.Instance.Train.TrainCars[0].gameObject.transform.position.x;
        Camera.main.GetComponent<CameraController>();
    }

    public void OnSecondCameraButtonClicked()
    {
        _xPos = CombatManager.Instance.Train.TrainCars[1].gameObject.transform.position.x;
        Camera.main.transform.Translate(new Vector3(_xPos, 0f));
    }

    public void OnThirdCameraButtonClicked()
    {
        _xPos = CombatManager.Instance.Train.TrainCars[2].gameObject.transform.position.x;
        Camera.main.transform.Translate(new Vector3(_xPos, 0f));
    }

    public void OnFourthCameraButtonClicked()
    {
        _xPos = CombatManager.Instance.Train.TrainCars[3].gameObject.transform.position.x;
        Camera.main.transform.Translate(new Vector3(_xPos, 0f));
    }

    public void OnFifthCameraButtonClicked()
    {
        _xPos = CombatManager.Instance.Train.TrainCars[4].gameObject.transform.position.x;
        Camera.main.transform.Translate(new Vector3(_xPos, 0f));
    }

    public void OnSixthCameraButtonClicked()
    {
        _xPos = CombatManager.Instance.Train.TrainCars[5].gameObject.transform.position.x;
        Camera.main.transform.Translate(new Vector3(_xPos, 0f));
    }
}
