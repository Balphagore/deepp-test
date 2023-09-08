using UnityEngine;

using DeeppTest.Weapons;

namespace DeeppTest.Characters
{
    public class EnemyController : CharacterController, IEnemyController
    {
        private IEnemyModel enemyModel;
        private IEnemyView enemyView;

        private IWeapon weapon;

        public void InitializeMVC(
                CharacterModelsFactory characterModelsFactory,
                CharacterViewsFactory characterViewsFactory,
                CharacterData characterData,
                SpawnDataModel spawnData,
                Transform parent
                )
        {
            enemyModel = characterModelsFactory.CreateEnemyCharacterModel(
                this,
                new Vector2(spawnData.SpawnTransform.rotation.eulerAngles.y, spawnData.SpawnTransform.rotation.eulerAngles.x),
                characterData.Health
                );
            characterModel = enemyModel;
            enemyView = characterViewsFactory.CreateEnemyView(this, characterData, spawnData, parent);
            characterView = enemyView;
        }

        public override void Dispose()
        {
            enemyModel = null;
            enemyView = null;
            base.Dispose();
        }

        public void GiveWeapon(IWeapon weapon)
        {
            weapon.WeaponTransform.SetParent(enemyView.WeaponSlotTransform, false);
            this.weapon = weapon;
        }

        public override void GetDamage(float value)
        {
            base.GetDamage(value);
        }
    }
}
