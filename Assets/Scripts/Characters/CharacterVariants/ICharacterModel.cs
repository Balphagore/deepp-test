
using UnityEngine;

namespace DeeppTest.Characters
{
    public interface ICharacterModel
    {
        void Initialize(ICharacterController characterController, Vector2 rotation, float health);

        void Dispose();

        void GetDamage(float value);
    }
}
