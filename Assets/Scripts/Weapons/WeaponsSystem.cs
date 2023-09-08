using UnityEngine;

namespace DeeppTest.Weapons
{
    public class WeaponsSystem : MonoBehaviour, IWeaponsSystem
    {
        [SerializeField]
        private WeaponDatabase weaponDatabase;

        public IWeapon GetWeapon()
        {
            GameObject instance = Instantiate(weaponDatabase.Laser.WeaponViewPrefab);
            IWeapon weapon = instance.GetComponent<IWeapon>();
            weapon.Initialize(weaponDatabase.Laser);
            return weapon;
        }
    }
}
