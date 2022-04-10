using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootGenerator : MonoBehaviour
{
    [SerializeField] GameObject commonLoot;
    [SerializeField] GameObject uncommonLoot;
    [SerializeField] GameObject rareLoot;
    [SerializeField] GameObject ultraRareLoot;
    [SerializeField] GameObject legendaryLoot;
    [SerializeField] GameObject ultraMegaRareLegendaryLoot;


    public void commonDrop()
    {
        Debug.Log("You got a common");
    }

    public void uncommonDrop()
    {
        Debug.Log("You got a uncommon");
    }

    public void rareDrop()
    {
        Debug.Log("You got a rare");
    }

    public void  ultraRareDrop()
    {
        Debug.Log("You got a ultra rare");
    }

    public void legendaryDrop()
    {
        Debug.Log("You got a legendary");
    }

    public void ultraMegaRareLegendaryDrop()
    {
        Debug.Log("You got a ultra mega rare legendary");
    }

}
