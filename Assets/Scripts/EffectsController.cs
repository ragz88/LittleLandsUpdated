using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Effects Controller", menuName = "Effects Controller")]
public class EffectsController : ScriptableObject
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
        Heatwave
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
