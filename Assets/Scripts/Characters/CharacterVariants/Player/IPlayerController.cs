using UnityEngine;

using DeeppTest.Weapons;

namespace DeeppTest.Characters
{
    public interface IPlayerController : ICharacterController
    {
        public void InitializeMVC(
            CharacterModelsFactory characterModelsFactory,
            CharacterViewsFactory characterViewsFactory,
            CharacterData characterData,
            SpawnDataModel spawnData,
            Transform parent,
            PlayerSettingsData playerSettings,
            ICharactersSystem characters
            );

        void MoveUpdate(Vector2 movementVector);

        void LookUpdate(Vector2 lookValue);

        void FireUpdate();

        void GiveWeapon(IWeapon weapon);
    }
}
