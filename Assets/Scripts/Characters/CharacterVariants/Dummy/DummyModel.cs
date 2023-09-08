using UnityEngine;

namespace DeeppTest.Characters
{
    public class DummyModel : CharacterModel, IDummyModel
    {
        private IDummyController dummyController;

        public void InitializeDummy(ICharacterController characterController, Vector2 rotation, float health)
        {
            base.Initialize(characterController, rotation, health);

            dummyController = (IDummyController)characterController;
        }

        public override void Dispose()
        {
            dummyController = null;
            base.Dispose();
        }

        public override void GetDamage(float value)
        {
            base.GetDamage(value);
        }
    }
}
