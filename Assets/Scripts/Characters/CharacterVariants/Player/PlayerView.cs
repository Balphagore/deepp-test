using UnityEngine;

namespace DeeppTest.Characters
{
    public class PlayerView : CharacterView, IPlayerView
    {
        [SerializeField]
        private PlayerMovement playerMovement;
        [SerializeField]
        private PlayerLook playerLook;

        [SerializeField]
        private Transform weaponSlot;

        private IPlayerController playerController;

        public Transform WeaponSlotTransform => weaponSlot;

        public override void Initialize(ICharacterController characterController)
        {
            base.Initialize(characterController);

            playerController = (IPlayerController)characterController;
        }

        public override void Dispose()
        {
            playerController = null;
            base.Dispose();
        }

        public void MoveView(Vector2 movementValue)
        {
            playerMovement.UpdateMovementDirection(movementValue);
        }

        public void RotateView(Vector2 rotationValue)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, rotationValue.x, 0));
            playerLook.UpdateLookDirection(rotationValue.y);
        }
    }
}
