using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCarInfo
{
    private string _id = string.Empty;
    public string ID => _id;

    private string _name = string.Empty;
    public string Name => _name;

    private TrainCarStat _stat = null;
    public TrainCarStat Stat => _stat;

    private Rank _rank = Rank.None;
    public Rank Rank => _rank;

    private TrainCarType _type = TrainCarType.None;
    public TrainCarType Type => _type;

    private SkillType _skillType = SkillType.None;
    public SkillType SkillType => _skillType;

    private SkillAimType _skillAimType = SkillAimType.None;
    public SkillAimType SkillAimType => _skillAimType;

    private bool _playerUse = true;
    public bool PlayerUse => _playerUse;

    public TrainCarInfo()
    {
        _id = string.Empty;
        _name = string.Empty;
        _stat = new TrainCarStat();
        _rank = Rank.None;
        _type = TrainCarType.None;
        _skillType = SkillType.None;
        _skillAimType = SkillAimType.None;
        _playerUse = true;
    }

    public TrainCarInfo(string id, string name, TrainCarStat stat, Rank rank, TrainCarType type, SkillType skillType, SkillAimType skillAimType, bool playerUse)
    {
        _id = id;
        _name = name;
        _stat = stat;
        _rank = rank;
        _type = type;
        _skillType = skillType;
        _skillAimType = skillAimType;
        _playerUse = playerUse;
    }
}
