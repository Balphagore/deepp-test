using UnityEngine;

using DeeppTest.Weapons;

namespace DeeppTest.Characters
{
    public class CharacterControllersFactory
    {
        private CharacterModelsFactory characterModelsFactory;
        private CharacterViewsFactory characterViewsFactory;

        public CharacterControllersFactory()
        {
            characterModelsFactory = new();
            characterViewsFactory = new();
        }

        public IPlayerController CreatePlayerController(
                CharacterData characterData,
                SpawnDataModel spawnData,
                Transform parent,
                PlayerSettingsData playerSettings,
                IWeapon weapon,
                ICharactersSystem characters
                )
        {
            IPlayerController playerController = new PlayerController();
            playerController.InitializeMVC(characterModelsFactory, characterViewsFactory, characterData, spawnData, parent, playerSettings, characters);
            playerController.GiveWeapon(weapon);
            return playerController;
        }

        public IEnemyController CreateEnemyController(
                CharacterData characterData,
                SpawnDataModel spawnData,
                Transform parent,
                IWeapon weapon
                )
        {
            IEnemyController enemyController = new EnemyController();
            enemyController.InitializeMVC(characterModelsFactory, characterViewsFactory, characterData, spawnData, parent);
            enemyController.GiveWeapon(weapon);
            return enemyController;
        }

        public IDummyController CreateDummyController(
                CharacterData characterData,
                SpawnDataModel spawnData,
                Transform parent
                )
        {
            IDummyController dummyController = new DummyController();
            dummyController.InitializeMVC(characterModelsFactory, characterViewsFactory, characterData, spawnData, parent);
            return dummyController;
        }
    }
}
