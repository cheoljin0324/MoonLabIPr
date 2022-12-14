using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaSystem : MonoBehaviour
{
    private float randomRarity = 0f;

    [SerializeField]
    public bool isTenGachaCanvas = false;

    public CharacterListSO characterList;

    public CharacterSO Gacha(int isTenGacha)
    {
        randomRarity = Random.Range(0f, 100f);
        CharacterSO character = null;

        if(isTenGacha != 9)
        {
            // 낮은 확률순으로
            // Rank 이거 확률 값으로 바꿔야하는데
            // 한정 픽업일때(특정 캐릭터의 확률이 올라가는거) 가챠도 만들어야함
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
        // 10번째 가챠일때
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

    // 해당 등급 리스트에 있는 캐릭터중 하나를 랜덤으로 뽑아온다
    public CharacterSO NormalGacha()
    {
        randomRarity = Random.Range(0, characterList.normalCharacterList.Count);

        return characterList.normalCharacterList[(int)randomRarity];
    }

    public CharacterSO RareGacha()
    {
        randomRarity = Random.Range(0, characterList.rareCharacterList.Count);

        return characterList.rareCharacterList[(int)randomRarity];
    }

    public CharacterSO SuperRareGacha()
    {
        randomRarity = Random.Range(0, characterList.superRareCharacterList.Count);

        return characterList.superRareCharacterList[(int)randomRarity];
    }
}
