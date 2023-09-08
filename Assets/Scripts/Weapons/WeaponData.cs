using UnityEngine;

namespace DeeppTest.Weapons
{
    [CreateAssetMenu(fileName = "WeaponData", menuName = "Game Data/Weapon Data")]
    public class WeaponData : ScriptableObject
    {
        public GameObject WeaponViewPrefab;
        public float Damage = 10;
        public int Ammo = 30;
        public float Range = 50;
        public float Cooldown = 0.5f;
    }
}
