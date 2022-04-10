using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltraRareDropSoundAndParticleEffects : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;
    [SerializeField] AudioSource dropSound;

    public void dropUltraRareLootEffect()
    {
        particle.Play();
        dropSound.Play();
    }
}
