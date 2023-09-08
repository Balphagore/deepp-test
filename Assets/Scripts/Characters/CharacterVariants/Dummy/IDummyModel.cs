using UnityEngine;

namespace DeeppTest.Characters
{
    public interface IDummyModel : ICharacterModel
    {
        void InitializeDummy(ICharacterController characterController, Vector2 rotation, float health);
    }
}
