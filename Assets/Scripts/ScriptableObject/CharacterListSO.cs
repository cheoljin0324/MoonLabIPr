using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Data/CharacterList")]
public class CharacterListSO : ScriptableObject
{
    public List<CharacterSO> normalCharacterList;
    public List<CharacterSO> rareCharacterList;
    public List<CharacterSO> superRareCharacterList;
}
