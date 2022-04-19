using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonDropSoundAndParticleEffects : MonoBehaviour
{

    [SerializeField] ParticleSystem particle;
    [SerializeField] AudioSource dropSound;

    public void dropCommonLootEffect()
    {
        particle.Play();
        dropSound.Play();
    }
}
