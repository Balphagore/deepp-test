using UnityEngine;

namespace DeeppTest.Weapons 
{
    public abstract class Weapon : MonoBehaviour, IWeapon
    {
        [SerializeField]
        protected Transform weaponTransform;

        protected float damage;
        protected int ammo;
        protected float range;
        protected float cooldown;

        public virtual Transform WeaponTransform => weaponTransform;

        public int Ammo => ammo;

        public virtual void Fire()
        {
            
        }

        public virtual void Initialize(WeaponData weaponData)
        {
            damage = weaponData.Damage;
            ammo = weaponData.Ammo;
            range = weaponData.Range;
            cooldown= weaponData.Cooldown;
        }
    }
}
