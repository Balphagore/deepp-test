using UnityEngine;

namespace DeeppTest.Weapons
{
    public class Gun : Weapon
    {
        public override void Fire()
        {
            Debug.LogWarning("Fire");
        }
    }
}
