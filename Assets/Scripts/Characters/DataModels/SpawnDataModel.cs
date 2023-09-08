using UnityEngine;

namespace DeeppTest.Characters
{
    public class SpawnDataModel
    {
        public readonly CharacterType CharacterType;
        public readonly Transform SpawnTransform;

        public SpawnDataModel(CharacterType characterType, Transform spawnTransform)
        {
            CharacterType = characterType;
            SpawnTransform = spawnTransform;
        }
    }
}
