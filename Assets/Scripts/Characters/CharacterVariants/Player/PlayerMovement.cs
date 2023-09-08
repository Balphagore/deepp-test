using UnityEngine;

namespace DeeppTest.Characters
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody characterRigidbody;

        private Vector3 velocity;

        private void FixedUpdate()
        {
            characterRigidbody.velocity = transform.TransformDirection(velocity);
        }

        public void UpdateMovementDirection(Vector2 movementVector)
        {
            velocity.x = movementVector.x;
            velocity.y = 0;
            velocity.z = movementVector.y;
        }
    }
}
