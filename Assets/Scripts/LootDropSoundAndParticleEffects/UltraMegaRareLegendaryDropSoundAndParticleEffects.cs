using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltraMegaRareLegendaryDropSoundAndParticleEffects : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;
    [SerializeField] AudioSource dropSound;

    public void dropUltraMegaRareLegendaryLootEffect()
    {
        particle.Play();
        dropSound.Play();
    }
}
