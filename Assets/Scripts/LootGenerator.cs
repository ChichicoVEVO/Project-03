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
        GameObject commonGun = Instantiate(commonLoot, LootMonster.transform);
        commonGun.GetComponent<CommonDropSoundAndParticleEffects>().dropCommonLootEffect();
    }

    public void uncommonDrop()
    {
        GameObject uncommonGun = Instantiate(uncommonLoot, LootMonster.transform);
        uncommonGun.GetComponent<UncommonDropSoundAndParticleEffects>().dropUncommonLootEffect();
    }

    public void rareDrop()
    {
        GameObject rareGun = Instantiate(rareLoot, LootMonster.transform);
        rareGun.GetComponent<RareDropSoundAndParticleEffects>().dropRareLootEffect();
    }

    public void  ultraRareDrop()
    {
        GameObject ultraRareGun = Instantiate(ultraRareLoot, LootMonster.transform);
        ultraRareGun.GetComponent<UltraRareDropSoundAndParticleEffects>().dropUltraRareLootEffect();
    }

    public void legendaryDrop()
    {
        GameObject legendaryGun = Instantiate(legendaryLoot, LootMonster.transform);
        legendaryGun.GetComponent<LegendaryDropSoundAndParticleEffects>().dropLegendaryLootEffect();
    }

    public void ultraMegaRareLegendaryDrop()
    {
        GameObject ultraMegaRareLegendary = Instantiate(ultraMegaRareLegendaryLoot, LootMonster.transform);
        ultraMegaRareLegendary.GetComponent<UltraMegaRareLegendaryDropSoundAndParticleEffects>().dropUltraMegaRareLegendaryLootEffect();
    }

}
