using UnityEngine;

namespace DeeppTest.Characters
{
    public abstract class CharacterController : ICharacterController
    {
        protected ICharacterModel characterModel;
        protected ICharacterView characterView;

        public virtual void Dispose()
        {
            characterModel.Dispose();
            characterView.Dispose();
        }

        public virtual void GetDamage(float value)
        {
            characterModel.GetDamage(value);
        }

        public virtual void KillCharacter()
        {
            Dispose();
        }
    }
}
