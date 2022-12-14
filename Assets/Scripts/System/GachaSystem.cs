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
            // ���� Ȯ��������
            // Rank �̰� Ȯ�� ������ �ٲ���ϴµ�
            // ���� �Ⱦ��϶�(Ư�� ĳ������ Ȯ���� �ö󰡴°�) ��í�� ��������
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
        // 10��° ��í�϶�
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

    // �ش� ��� ����Ʈ�� �ִ� ĳ������ �ϳ��� �������� �̾ƿ´�
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
