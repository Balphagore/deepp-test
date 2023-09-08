using UnityEngine;

namespace DeeppTest.Characters
{
    public interface IEnemyModel : ICharacterModel
    {
        void InitializeEnemy(ICharacterController characterController, Vector2 rotation, float health);
    }
}
