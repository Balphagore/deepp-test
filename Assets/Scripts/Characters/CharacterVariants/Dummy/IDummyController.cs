using UnityEngine;

namespace DeeppTest.Characters
{
    public interface IDummyController : ICharacterController
    {
        void InitializeMVC(
            CharacterModelsFactory characterModelsFactory,
            CharacterViewsFactory characterViewsFactory,
            CharacterData characterData,
            SpawnDataModel spawnData,
            Transform parent
            );
    }
}
