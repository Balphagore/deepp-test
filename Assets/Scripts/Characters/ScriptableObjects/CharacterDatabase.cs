using UnityEngine;

namespace DeeppTest.Characters
{
    [CreateAssetMenu(fileName = "CharacterDatabase", menuName = "Game Data/Character Database")]
    public class CharacterDatabase : ScriptableObject
    {
        public CharacterData PlayerData;
        public CharacterData EnemyData;
        public CharacterData DummyData;
    }
}
