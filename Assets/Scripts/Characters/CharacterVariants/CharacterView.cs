using UnityEngine;

using DeeppTest.Weapons;

namespace DeeppTest.Characters
{
    public abstract class CharacterView : MonoBehaviour, ICharacterView, IDamagable
    {
        private ICharacterController characterController;

        public virtual void Initialize(ICharacterController characterController)
        {
            this.characterController = characterController;
        }

        public virtual void Dispose()
        {
            Destroy(gameObject);
        }

        public virtual void GetDamage(float value)
        {
            characterController.GetDamage(value);
        }
    }
}
