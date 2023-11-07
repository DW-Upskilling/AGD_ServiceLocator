using System.Collections.Generic;
using UnityEngine;

namespace ServiceLocator.Wave.Bloon
{
    [CreateAssetMenu(fileName = "BloonScriptableObject", menuName = "ScriptableObjects/BloonScriptableObject")]
    public class BloonScriptableObject : ScriptableObject
    {
        public BloonType Type;
        public int Health;
        public int Damage;
        public int Reward;
        public float Speed;
        public Sprite Sprite;
        public List<BloonType> LayeredBloons;
        public float LayerBloonSpawnRate;
    }
}