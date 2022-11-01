using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCar : MonoBehaviour
{
    private TrainCarInfo trainCarInfo = null;
    private Skill skill;

    private void Start()
    {
        skill = transform.parent.GetComponent<Train>()._skill;
    }

    private void OnMouseDown()
    {
        SkillManager.Instance.UseSkill(skill);
    }
}
