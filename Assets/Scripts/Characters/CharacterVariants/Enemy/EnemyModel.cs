using UnityEngine;

namespace DeeppTest.Characters
{
    public class EnemyModel : CharacterModel, IEnemyModel
    {
        private IEnemyController enemyController;

        public float Health { get => health; set => health = value; }

        public void InitializeEnemy(ICharacterController characterController, Vector2 rotation, float health)
        {
            base.Initialize(characterController, rotation, health);

            enemyController = (IEnemyController)characterController;
        }

        public override void Dispose()
        {
            enemyController = null;
            base.Dispose();
        }

        public override void GetDamage(float value)
        {
            base.GetDamage(value);
        }
    }
}
