using UnityEngine;

namespace DeeppTest.Characters
{
    public abstract class CharacterModel : ICharacterModel
    {
        private ICharacterController characterController;
        protected Vector2 rotation;
        protected float health;

        public virtual void Initialize(ICharacterController characterController, Vector2 rotation, float health)
        {
            this.characterController = characterController;
            this.rotation = rotation;
            this.health = health;
        }

        public virtual void Dispose()
        {
            characterController = null;
        }

        public virtual void GetDamage(float value)
        {
            health -= value;
            if(health<=0)
            {
                characterController.KillCharacter();
            }
        }
    }
}
