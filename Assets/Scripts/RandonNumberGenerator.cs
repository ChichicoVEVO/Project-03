using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandonNumberGenerator : MonoBehaviour
{
    public float qualityRandomNum;
    public float quanityRandomNum;
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
                    Debug.Log("You got a nothing");
                }

                if (qualityRandomNum <= 70 && qualityRandomNum >= 31)
                {
                    Debug.Log("You got a uncommon");
                }

                if (qualityRandomNum <= 85 && qualityRandomNum >= 71)
                {
                    Debug.Log("You got a rare");
                }

                if (qualityRandomNum <= 94 && qualityRandomNum >= 86)
                {
                    Debug.Log("You got a ultra rare");
                }

                if (qualityRandomNum <= 99 && qualityRandomNum >= 95)
                {
                    Debug.Log("You got a legendary");
                }

                if (qualityRandomNum == 100)
                {
                    Debug.Log("ULTRA MEGA RARE LEGENDARY");
                }
            }
        }
    }
}
