using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UncommonDropSoundAndParticleEffects : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;
    [SerializeField] AudioSource dropSound;

    public void dropUncommonLootEffect()
    {
        particle.Play();
        dropSound.Play();
    }
}
