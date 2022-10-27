using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCarInfo
{
    private string _id = string.Empty;
    private string _name = string.Empty;
    private TrainCarStat _stat = null;
    private Rank _rank = Rank.None;
    private TrainCarType _type = TrainCarType.None;
    private SkillType _skillType = SkillType.None;
    private SkillAimType _skillAimType = SkillAimType.None;
    private bool _playerUse = true;
}
