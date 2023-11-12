using System.Collections.Generic;
using UnityEngine;
using ServiceLocator.Wave.Bloon;
using ServiceLocator.Player.Projectile;
using ServiceLocator.Sound;

namespace ServiceLocator.Player
{
    public class MonkeyController
    {
        private MonkeyView monkeyView;
        private MonkeyScriptableObject monkeyScriptableObject;
        private ProjectilePool projectilePool;

        private float attackTimer;
        private List<BloonController> bloons;

        public MonkeyController(MonkeyScriptableObject monkeyScriptableObject, ProjectilePool projectilePool)
        {
            this.monkeyScriptableObject = monkeyScriptableObject;
            this.projectilePool = projectilePool;

            bloons = new List<BloonController>();

            CreateMonkeyView();
            ResetAttackTimer();
        }

        private void CreateMonkeyView()
        {
            monkeyView = Object.Instantiate(monkeyScriptableObject.Prefab);
            monkeyView.SetController(this);
            monkeyView.SetTriggerRadius(monkeyScriptableObject.Range);
        }

        public void SetPosition(Vector3 positionToSet) => monkeyView.transform.position = positionToSet;

        public bool CanAttackBloon(BloonType bloonType) => monkeyScriptableObject.AttackableBloons.Contains(bloonType);

        private void ResetAttackTimer() => attackTimer = monkeyScriptableObject.AttackRate;

        public void BloonEnteredRange(BloonController bloon) {
            if (CanAttackBloon(bloon.GetBloonType()))
                bloons.Add(bloon);
        }

        public void BloonExitedRange(BloonController bloon) {
            if (CanAttackBloon(bloon.GetBloonType()))
                bloons.Remove(bloon);
        }

        public void UpdateMonkey()
        {
            if(bloons.Count > 0) {
                RotateTowardsTarget(bloons[0]);
                ShootAtTarget(bloons[0]);
            }
        }

        private void RotateTowardsTarget(BloonController bloon)
        {
            Vector3 direction = bloon.Position - monkeyView.transform.position;
            float angle = 180 + Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            monkeyView.transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }

        private void ShootAtTarget(BloonController bloon)
        {
            attackTimer -= Time.deltaTime;
            if(attackTimer <= 0)
            {
                ProjectileController projectile = projectilePool.GetProjectile(monkeyScriptableObject.projectileType);
                projectile.SetPosition(monkeyView.transform.position);
                projectile.SetTarget(bloon);
                GameService.Instance.SoundService.PlaySoundEffects(Sound.SoundType.MonkeyShoot);
                ResetAttackTimer();
            }
        }
    }
}