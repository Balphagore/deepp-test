using UnityEngine;

using DeeppTest.Weapons;

namespace DeeppTest.Characters
{
    public class PlayerController : CharacterController, IPlayerController
    {
        private IPlayerModel playerModel;
        private IPlayerView playerView;

        private IWeapon weapon;

        private ICharactersSystem characters;

        public void InitializeMVC(
                CharacterModelsFactory characterModelsFactory,
                CharacterViewsFactory characterViewsFactory,
                CharacterData characterData,
                SpawnDataModel spawnData,
                Transform parent,
                PlayerSettingsData playerSettings,
                ICharactersSystem characters
                )
        {
            playerModel = characterModelsFactory.CreatePlayerCharacterModel(
                this,
                new Vector2(spawnData.SpawnTransform.rotation.eulerAngles.y, spawnData.SpawnTransform.rotation.eulerAngles.x),
                characterData.Health,
                characterData.MovementSpeed,
                playerSettings.CameraSensitivity
                );
            characterModel = playerModel;
            playerView = characterViewsFactory.CreatePlayerView(this, characterData, spawnData, parent);
            characterView = playerView;
            this.characters = characters;
        }

        public override void Dispose()
        {
            playerModel = null;
            characterView = null;
            weapon = null;
            base.Dispose();
        }

        public void MoveUpdate(Vector2 movementVector)
        {
            float speed = playerModel.MovementSpeed;
            playerView.MoveView(movementVector * speed);
        }

        public void LookUpdate(Vector2 lookValue)
        {
            Vector2 rotation = playerModel.Rotation;
            rotation.x += lookValue.x * Time.smoothDeltaTime * playerModel.RotationSensitivity;
            rotation.y -= lookValue.y * Time.smoothDeltaTime * playerModel.RotationSensitivity;
            rotation.y = Mathf.Clamp(rotation.y, -90, 90);
            playerModel.Rotation = rotation;
            playerView.RotateView(rotation);
        }

        public void FireUpdate()
        {
            weapon.Fire();
            characters.UpdateAmmoCounter(weapon.Ammo);
        }

        public void GiveWeapon(IWeapon weapon)
        {
            weapon.WeaponTransform.SetParent(playerView.WeaponSlotTransform, false);
            this.weapon = weapon;

            characters.UpdateAmmoCounter(weapon.Ammo);
        }
    }
}
