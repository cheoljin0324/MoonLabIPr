using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaSystem : MonoBehaviour
{
    public enum RARITY
    {
        RARE = 100,
        SR = 30,
        SSR = 5,
    }

    private float randomRarity = 0f;

    private GameObject[] rareCharacter;

    public void Gacha(bool isTenGacha)
    {
        randomRarity = Random.Range(0f, 100f);
        if(isTenGacha == true)
        {
            if (randomRarity <= (float)RARITY.SSR)
            {
                SSRGacha();
            }
            else if (randomRarity <= (float)RARITY.SR)
            {
                SRGacha();
            }
            else if (randomRarity <= (float)RARITY.RARE)
            {
                RareGacha();
            }
        }
        else
        {
            if (randomRarity <= (float)RARITY.SSR)
            {
                SSRGacha();
            }
            else if (randomRarity <= (float)RARITY.RARE)
            {
                SRGacha();
            }
        }
    }

    public void RareGacha()
    {
        randomRarity = Random.Range(0, rareCharacter.Length);

        //return rareCharacter[(int)randomRarity];
    }

    public void SRGacha()
    {

    }

    public void SSRGacha()
    {

    }
}
