using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RareDropSoundAndParticleEffects : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;
    [SerializeField] AudioSource dropSound;

    public void dropRareLootEffect()
    {
        particle.Play();
        dropSound.Play();
        Debug.Log("pkye check");
    }
}
