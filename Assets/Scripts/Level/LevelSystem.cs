using System;
using System.Collections.Generic;
using UnityEngine;

using DeeppTest.Characters;

namespace DeeppTest.Level
{
    public class LevelSystem : MonoBehaviour, ILevelSystem
    {
        [SerializeField]
        private GameObject charactersReference;
        [SerializeField]
        private List<SpawnPointData> spawnPoints;

        private ICharactersSystem characters;

        private void Awake()
        {
            characters = charactersReference.GetComponent<ICharactersSystem>();
        }

        private void Start()
        {
            spawnPoints.ForEach(spawnPoint =>
            {
                characters.SpawnCharacter(new SpawnDataModel(spawnPoint.CharacterType, spawnPoint.SpawnTransform));
            });
        }

        private void OnValidate()
        {
            spawnPoints.ForEach(spawnPoint =>
            {
                if (spawnPoint.SpawnTransform == null || spawnPoint.CharacterType == CharacterType.None)
                {
                    throw new ArgumentException("SpawnPoint values incorrect");
                }
            });
        }
    }

    [Serializable]
    public class SpawnPointData
    {
        public string Id;
        public CharacterType CharacterType;
        public Transform SpawnTransform;
    }
}
