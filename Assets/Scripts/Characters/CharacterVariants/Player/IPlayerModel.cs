using UnityEngine;

namespace DeeppTest.Characters
{
    public interface IPlayerModel : ICharacterModel
    {
        void InitializePlayer(ICharacterController characterController, Vector2 rotation, float health, float movementSpeed, float rotationSensitivity);

        float MovementSpeed { get; }

        Vector2 Rotation { get; set; }

        float RotationSensitivity { get; set; }
    }
}
