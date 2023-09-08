using UnityEngine;

namespace DeeppTest.Characters
{
    public class EnemyView : CharacterView, IEnemyView
    {
        [SerializeField]
        private Transform weaponSlot;

        private IEnemyController enemyController;

        public Transform WeaponSlotTransform => weaponSlot;

        public override void Initialize(ICharacterController characterController)
        {
            base.Initialize(characterController);

            enemyController = (IEnemyController)characterController;
        }

        public override void Dispose()
        {
            enemyController = null;
            base.Dispose();
        }
    }
}
