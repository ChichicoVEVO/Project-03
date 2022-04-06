using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandonNumberGenerator : MonoBehaviour
{
    public float randomNum;
    private void Start()
    {
        randomNum = Random.Range(0, 100);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            randomNum = Random.Range(1, 100);
            Debug.Log("Random Number is " + randomNum);

            if (randomNum <= 49)
            {
                Debug.Log("You got a common");
            }

            if (randomNum <= 69 && randomNum >= 50)
            {
                Debug.Log("You got a uncommon");
            }

            if (randomNum <= 79 && randomNum >= 70)
            {
                Debug.Log("You got a rare");
            }
        }
    }
}
