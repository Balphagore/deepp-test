using UnityEngine;

namespace DeeppTest.Characters
{
    public class DummyController : CharacterController, IDummyController
    {
        private IDummyModel dummyModel;
        private IDummyView dummyView;

        public void InitializeMVC(
                CharacterModelsFactory characterModelsFactory,
                CharacterViewsFactory characterViewsFactory,
                CharacterData characterData,
                SpawnDataModel spawnData,
                Transform parent
                )
        {
            dummyModel = characterModelsFactory.CreateDummyCharacterModel(
                this,
                new Vector2(spawnData.SpawnTransform.rotation.eulerAngles.y, spawnData.SpawnTransform.rotation.eulerAngles.x),
                characterData.Health
                );
            characterModel = dummyModel;
            dummyView = characterViewsFactory.CreateDummyView(this, characterData, spawnData, parent);
            characterView = dummyView;
        }

        public override void Dispose()
        {
            dummyModel = null;
            dummyView = null;
            base.Dispose();
        }
    }
}
