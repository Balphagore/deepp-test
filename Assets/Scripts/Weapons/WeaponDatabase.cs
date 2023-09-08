using UnityEngine;

namespace DeeppTest.Weapons
{
    [CreateAssetMenu(fileName = "WeaponDatabase", menuName = "Game Data/Weapon Database")]
    public class WeaponDatabase : ScriptableObject
    {
        public WeaponData Gun;
        public WeaponData Laser;
    }
}
