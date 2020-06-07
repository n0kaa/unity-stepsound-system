using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DiasGames.ThirdPersonSystem;

public class StepSystem : MonoBehaviour
{
    [SerializeField] AudioClip[] stepSounds;
    [SerializeField] AudioClip[] stepSoundsTerrain;
    [SerializeField] AudioSource stepAudioSource;
    [SerializeField] GameObject Terrain;
    [SerializeField] ThirdPersonSystem tps;
    public void PlayStep()
    {
        if (tps.GroundHitInfo.collider.gameObject == Terrain)
        {
            stepAudioSource.clip = stepSoundsTerrain[Random.Range(0, stepSoundsTerrain.Length)];
            stepAudioSource.pitch = Random.Range(0.9f, 1.1f);
            stepAudioSource.Play();
        }
        else if(tps.GroundHitInfo.transform.gameObject.CompareTag("Wood"))
        {
            stepAudioSource.clip = stepSounds[Random.Range(0, stepSounds.Length)];
            stepAudioSource.pitch = Random.Range(0.6f, 1.4f);
            stepAudioSource.Play();
        }
    }
}
