using UnityEngine;

namespace DeeppTest.Characters
{
    public interface IEnemyView : ICharacterView
    {
        Transform WeaponSlotTransform { get; }
    }
}
