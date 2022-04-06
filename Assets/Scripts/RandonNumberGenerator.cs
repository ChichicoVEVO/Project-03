﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandonNumberGenerator : MonoBehaviour
{
    int qualityRandomNum;
    int quanityRandomNum;
    [SerializeField] LootGenerator callCommonDrop;
    [SerializeField] LootGenerator callUncommonDrop;
    [SerializeField] LootGenerator callRareDrop;
    [SerializeField] LootGenerator callUltraRareDrop;
    [SerializeField] LootGenerator callLegendaryDrop;
    [SerializeField] LootGenerator callUltraMegaRareLegendaryDrop;
    private void Start()

    {
        quanityRandomNum = Random.Range(1, 6);
        qualityRandomNum = Random.Range(0, 100);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
            Debug.Log("You got " + quanityRandomNum + "guns");
        {
            for (int noLoot = 0; noLoot < quanityRandomNum; quanityRandomNum--)
            {
                qualityRandomNum = Random.Range(1, 100);
                Debug.Log("Random Number is " + qualityRandomNum);

                if (qualityRandomNum <= 30) 
                {
                    callCommonDrop.GetComponent<LootGenerator>().commonDrop();
                }

                if (qualityRandomNum <= 70 && qualityRandomNum >= 31)  
                {
                    callUncommonDrop.GetComponent<LootGenerator>().uncommonDrop();
                }

                if (qualityRandomNum <= 85 && qualityRandomNum >= 71)
                {
                    callRareDrop.GetComponent<LootGenerator>().rareDrop();
                }

                if (qualityRandomNum <= 94 && qualityRandomNum >= 86)
                {
                    callUltraRareDrop.GetComponent<LootGenerator>().ultraRareDrop();
                }

                if (qualityRandomNum <= 99 && qualityRandomNum >= 95)
                {
                    callLegendaryDrop.GetComponent<LootGenerator>().legendaryDrop();
                }

                if (qualityRandomNum == 100)
                {
                    callUltraMegaRareLegendaryDrop.GetComponent<LootGenerator>().ultraMegaRareLegendaryDrop();
                }
            }
        }
    }
}
