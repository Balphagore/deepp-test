using UnityEngine;

namespace DeeppTest.Characters
{
    public interface IPlayerView : ICharacterView
    {
        void MoveView(Vector2 movementValue);

        void RotateView(Vector2 rotationValue);

        Transform WeaponSlotTransform { get; }
    }
}
