using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Biome", menuName = "Biome")]
public class Biome : ScriptableObject
{
    [SerializeField]
    public GameObject biomeBody;
    
    [System.Serializable]
    public struct Fusion
    {
        public Biome fusionPartner;
        public Biome result;

        /// <summary>
        /// The visual effect prefab that should spawn upon this fusion happening.
        /// </summary>
        [SerializeField]
        public EffectsSettings.EffectType effects;
    }

    [SerializeField]
    public Fusion[] fusions;
}
