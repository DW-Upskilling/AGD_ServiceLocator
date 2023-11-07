using System.Collections.Generic;
using UnityEngine;
using ServiceLocator.Player.Projectile;
using ServiceLocator.Wave.Bloon;

namespace ServiceLocator.Player
{
    [CreateAssetMenu(fileName = "MonkeyScriptableObject", menuName = "ScriptableObjects/MonkeyScriptableObject")]
    public class MonkeyScriptableObject : ScriptableObject
    {
        public MonkeyType Type;
        public MonkeyView Prefab;
        public float RotationSpeed;
        public ProjectileType projectileType;
        public float Range;
        public int Cost;
        public List<BloonType> AttackableBloons;
        public float AttackRate;
    }
}