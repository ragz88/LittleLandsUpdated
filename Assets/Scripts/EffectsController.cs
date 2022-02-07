using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EffectsController : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField]
    public EffectsSettings effectsSettings;

    public static EffectsController soundControllerInstance;

    private void Awake()
    {
        if (soundControllerInstance == null)
        {
            soundControllerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
    }


    public void PlayWinSound()
    {
        audioSource.PlayOneShot(effectsSettings.winNoise, 1);
    }

    public void PlayLoseSound()
    {
        audioSource.PlayOneShot(effectsSettings.loseNoise, 1);
    }

    public void PlaySmallWinSound()
    {
        audioSource.PlayOneShot(effectsSettings.smallWinNoise, 1);
    }


    public void PlayMergeEffect(EffectsSettings.EffectType type, Vector3 position)
    {
        bool typeFound = false;

        for (int i = 0; i < effectsSettings.effectCollections.Length; i++)
        {
            if (effectsSettings.effectCollections[i].type == type)
            {
                typeFound = true;
                audioSource.PlayOneShot(effectsSettings.effectCollections[i].soundEffect, 0.4f);

                if (effectsSettings.effectCollections[i].effectPrefab != null)
                {
                    Instantiate(effectsSettings.effectCollections[i].effectPrefab, position, Quaternion.identity);
                }
                break;
            }
        }

        if (!typeFound)
        {
            Debug.LogError("Effect " + type.ToString() + " was not found. No sound played.");
        }
    }
}
