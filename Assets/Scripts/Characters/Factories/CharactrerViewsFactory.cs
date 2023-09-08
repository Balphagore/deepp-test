using UnityEngine;

namespace DeeppTest.Characters
{
    public class CharacterViewsFactory
    {
        public IPlayerView CreatePlayerView(
            ICharacterController characterController, 
            CharacterData characterData, 
            SpawnDataModel spawnData, 
            Transform parent
            )
        {
            GameObject instance = Object.Instantiate(
                characterData.CharacterViewPrefab, 
                spawnData.SpawnTransform.position, 
                Quaternion.Euler(spawnData.SpawnTransform.eulerAngles), 
                parent
                );
            IPlayerView playerView = instance.GetComponent<IPlayerView>();
            playerView.Initialize(characterController);
            return playerView;
        }

        public IEnemyView CreateEnemyView(
            ICharacterController characterController,
            CharacterData characterData,
            SpawnDataModel spawnData,
            Transform parent
            )
        {
            GameObject instance = Object.Instantiate(
                characterData.CharacterViewPrefab, 
                spawnData.SpawnTransform.position, 
                Quaternion.Euler(spawnData.SpawnTransform.eulerAngles), 
                parent
                );
            IEnemyView enemyView = instance.GetComponent<IEnemyView>();
            enemyView.Initialize(characterController);
            return enemyView;
        }

        public IDummyView CreateDummyView(
            ICharacterController characterController,
            CharacterData characterData,
            SpawnDataModel spawnData,
            Transform parent
            )
        {
            GameObject instance = Object.Instantiate(
                characterData.CharacterViewPrefab,
                spawnData.SpawnTransform.position,
                Quaternion.Euler(spawnData.SpawnTransform.eulerAngles),
                parent
                );
            IDummyView dummyView = instance.GetComponent<IDummyView>();
            dummyView.Initialize(characterController);
            return dummyView;
        }
    }
}
