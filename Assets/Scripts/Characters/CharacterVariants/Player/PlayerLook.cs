using UnityEngine;

namespace DeeppTest.Characters
{
    public class PlayerLook : MonoBehaviour
    {
        [SerializeField]
        private Transform cameraTransform;

        public void UpdateLookDirection(float cameraRotation)
        {
            cameraTransform.localRotation = Quaternion.Euler(new Vector3(cameraRotation, 0, 0));
        }
    }
}
