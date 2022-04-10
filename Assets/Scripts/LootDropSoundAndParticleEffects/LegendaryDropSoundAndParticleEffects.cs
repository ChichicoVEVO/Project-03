using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegendaryDropSoundAndParticleEffects : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;
    [SerializeField] AudioSource dropSound;

    public void dropLegendaryLootEffect()
    {
        particle.Play();
        dropSound.Play();
    }
}
