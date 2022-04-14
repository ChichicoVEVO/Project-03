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

    [SerializeField] GameObject LootMonster;

    


    public void commonDrop()
    {
        Instantiate(commonLoot, LootMonster.transform);
        Debug.Log("You got a common");
    }

    public void uncommonDrop()
    {
        Instantiate(uncommonLoot, LootMonster.transform);
        Debug.Log("You got a uncommon");
    }

    public void rareDrop()
    {
        Instantiate(rareLoot, LootMonster.transform);
        Debug.Log("You got a rare");
    }

    public void  ultraRareDrop()
    {
        Instantiate(ultraRareLoot, LootMonster.transform);
        Debug.Log("You got a ultra rare");
    }

    public void legendaryDrop()
    {
        Instantiate(legendaryLoot, LootMonster.transform);
        Debug.Log("You got a legendary");
    }

    public void ultraMegaRareLegendaryDrop()
    {
        Instantiate(ultraMegaRareLegendaryLoot, LootMonster.transform);
        Debug.Log("You got a ultra mega rare legendary");
    }

}
