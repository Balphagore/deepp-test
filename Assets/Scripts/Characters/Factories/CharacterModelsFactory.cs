using UnityEngine;

namespace DeeppTest.Characters
{
    public class CharacterModelsFactory
    {
        public IPlayerModel CreatePlayerCharacterModel(
                ICharacterController characterController, 
                Vector2 rotation, 
                float health,
                float movementSpeed, 
                float rotationSensitivity
                )
        {
            IPlayerModel playerModel = new PlayerModel();
            playerModel.InitializePlayer(characterController, rotation, health, movementSpeed, rotationSensitivity);
            return playerModel;
        }

        public IEnemyModel CreateEnemyCharacterModel(
                ICharacterController characterController, 
                Vector2 rotation,
                float health
                )
        {
            IEnemyModel enemyModel = new EnemyModel();
            enemyModel.InitializeEnemy(characterController, rotation, health);
            return enemyModel;
        }

        public IDummyModel CreateDummyCharacterModel(
                ICharacterController characterController, 
                Vector2 rotation,
                float health
                )
        {
            IDummyModel dummyModel = new DummyModel();
            dummyModel.InitializeDummy(characterController, rotation, health);
            return dummyModel;
        }
    }
}
