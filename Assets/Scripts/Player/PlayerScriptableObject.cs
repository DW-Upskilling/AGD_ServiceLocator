using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ServiceLocator.Player.Projectile;

namespace ServiceLocator.Player
{
    [CreateAssetMenu(fileName = "PlayerScriptableObject", menuName = "ScriptableObjects/PlayerScriptableObject")]
    public class PlayerScriptableObject : ScriptableObject
    {
        public int Health;
        public int Money;
        public List<MonkeyScriptableObject> MonkeyScriptableObjects;
        public List<ProjectileScriptableObject> ProjectileScriptableObjects;
        public ProjectileView ProjectilePrefab;
    }
}