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

    [SerializeField] CommonDropSoundAndParticleEffects playCommonDropEffects;
    [SerializeField] UncommonDropSoundAndParticleEffects playUncommonDropEffects;
    [SerializeField] RareDropSoundAndParticleEffects playRareDropEffects;
    [SerializeField] UltraRareDropSoundAndParticleEffects playUltraRareDropEffects;
    [SerializeField] LegendaryDropSoundAndParticleEffects playLegendaryDropEffects;
    [SerializeField] UltraMegaRareLegendaryDropSoundAndParticleEffects playUltraMegaRareLegendaryDropEffects;

    [SerializeField] GameObject LootMonster;    


    public void commonDrop()
    {
        Instantiate(commonLoot, LootMonster.transform);
        playCommonDropEffects.GetComponent<CommonDropSoundAndParticleEffects>().dropCommonLootEffect();
    }

    public void uncommonDrop()
    {
        Instantiate(uncommonLoot, LootMonster.transform);
        playUncommonDropEffects.GetComponent<UncommonDropSoundAndParticleEffects>().dropUncommonLootEffect();
    }

    public void rareDrop()
    {
        Instantiate(rareLoot, LootMonster.transform);
        playRareDropEffects.GetComponent<RareDropSoundAndParticleEffects>().dropRareLootEffect();
    }

    public void  ultraRareDrop()
    {
        Instantiate(ultraRareLoot, LootMonster.transform);
        playUltraRareDropEffects.GetComponent<UltraRareDropSoundAndParticleEffects>().dropUltraRareLootEffect();
    }

    public void legendaryDrop()
    {
        Instantiate(legendaryLoot, LootMonster.transform);
        playLegendaryDropEffects.GetComponent<LegendaryDropSoundAndParticleEffects>().dropLegendaryLootEffect();
    }

    public void ultraMegaRareLegendaryDrop()
    {
        Instantiate(ultraMegaRareLegendaryLoot, LootMonster.transform);
        playUltraMegaRareLegendaryDropEffects.GetComponent<UltraMegaRareLegendaryDropSoundAndParticleEffects>().dropUltraMegaRareLegendaryLootEffect();
    }

}
