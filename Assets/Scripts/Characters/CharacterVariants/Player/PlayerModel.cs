using UnityEngine;

namespace DeeppTest.Characters
{
    public class PlayerModel : CharacterModel, IPlayerModel
    {
        private IPlayerController playerController;

        private float movementSpeed;
        private float rotationSensitivity;

        public Vector2 Rotation { get => rotation; set => rotation = value; }
        public float MovementSpeed => movementSpeed;
        public float RotationSensitivity { get => rotationSensitivity; set => rotationSensitivity = value; }

        public void InitializePlayer(ICharacterController characterController, Vector2 rotation, float health, float movementSpeed , float rotationSensitivity)
        {
            base.Initialize(characterController, rotation, health);

            playerController = (IPlayerController)characterController;
            this.movementSpeed = movementSpeed;
            this.rotationSensitivity = rotationSensitivity;
        }

        public override void Dispose()
        {
            playerController = null;
            base.Dispose();
        }

        public override void GetDamage(float value)
        {
            base.GetDamage(value);
        }
    }
}
