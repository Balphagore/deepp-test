namespace DeeppTest.Characters
{
    public class DummyView : CharacterView, IDummyView
    {
        private IDummyController dummyController;

        public override void Initialize(ICharacterController characterController)
        {
            base.Initialize(characterController);

            dummyController = (IDummyController)characterController;
        }

        public override void Dispose()
        {
            dummyController = null;
            base.Dispose();
        }
    }
}
