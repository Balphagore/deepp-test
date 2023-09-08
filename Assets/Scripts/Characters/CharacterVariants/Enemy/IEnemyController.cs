using UnityEngine;

using DeeppTest.Weapons;

namespace DeeppTest.Characters
{
    public interface IEnemyController : ICharacterController
    {
        void InitializeMVC(
            CharacterModelsFactory characterModelsFactory,
            CharacterViewsFactory characterViewsFactory,
            CharacterData characterData,
            SpawnDataModel spawnData,
            Transform parent
            );

        void GiveWeapon(IWeapon weapon);
    }
}
