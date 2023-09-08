using TMPro;
using UnityEngine;

namespace DeeppTest.UI
{
    public class UISystem : MonoBehaviour, IUISystem
    {
        [SerializeField]
        private TextMeshProUGUI ammoCounterText;

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        public void UpdateAmmoCounter(int value)
        {
            ammoCounterText.text = "Ammo: " + value;
        }
    }
}
