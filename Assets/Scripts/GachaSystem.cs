using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaSystem : MonoBehaviour
{
    private float randomRarity = 0f;

    public List<CharacterSO> normalCharacterList = new List<CharacterSO>();
    public List<CharacterSO> rareCharacterList = new List<CharacterSO>();
    public List<CharacterSO> superRareCharacterList = new List<CharacterSO>();

    public CharacterSO Gacha(bool isTenGacha)
    {
        randomRarity = Random.Range(0f, 100f);
        CharacterSO character = null;

        if(isTenGacha == true)
        {
            if (randomRarity <= (float)Rank.SuperRare)
            {
                character = SuperRareGacha();
            }
            else if (randomRarity <= (float)Rank.Rare)
            {
                character = RareGacha();
            }
            else if (randomRarity <= (float)Rank.Normal)
            {
                character = NormalGacha();
            }
        }
        else
        {
            if (randomRarity <= (float)Rank.SuperRare)
            {
                character = SuperRareGacha();
            }
            else if (randomRarity <= (float)Rank.Rare)
            {
                character = RareGacha();
            }
        }
        
        return character;
    }

    public CharacterSO NormalGacha()
    {
        randomRarity = Random.Range(0, normalCharacterList.Count);

        return normalCharacterList[(int)randomRarity];
    }

    public CharacterSO RareGacha()
    {
        randomRarity = Random.Range(0, rareCharacterList.Count);

        return rareCharacterList[(int)randomRarity];
    }

    public CharacterSO SuperRareGacha()
    {
        randomRarity = Random.Range(0, superRareCharacterList.Count);

        return superRareCharacterList[(int)randomRarity];
    }
}
