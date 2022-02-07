using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Effects Settings", menuName = "Effects Settings")]
public class EffectsSettings : ScriptableObject
{
    [System.Serializable]
    public enum EffectType
    {
        Freeze,
        Burn,
        Sandfall,
        MountainRise,
        Waterfall,
        PlantGrowth,
        Heatwave,
        Sizzle
    }

    [System.Serializable]
    public struct EffectCollection
    {
        public EffectType type;
        public GameObject effectPrefab;
        public AudioClip soundEffect;
    }

    public EffectCollection[] effectCollections;
}
