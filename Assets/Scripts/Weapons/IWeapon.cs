using UnityEngine;

namespace DeeppTest.Weapons
{
    public interface IWeapon
    {
        Transform WeaponTransform { get; }
        int Ammo { get; }

        void Initialize(WeaponData weaponData);

        void Fire();
    }
}
