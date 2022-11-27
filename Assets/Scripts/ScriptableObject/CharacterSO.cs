using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Data/Character")]
public class CharacterSO : ScriptableObject
{
    public Rank characterRank;
    public string characterName;
    public int hp;
    public int maxHp;
    public int attack;
    public int defense;
}
