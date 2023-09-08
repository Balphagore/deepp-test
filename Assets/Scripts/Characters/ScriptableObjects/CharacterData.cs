using UnityEngine;

namespace DeeppTest.Characters
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "Game Data/Character Data")]
    public class CharacterData : ScriptableObject
    {
        public GameObject CharacterViewPrefab;
        [Range(0f, 100f)]
        public float MovementSpeed = 5;
        public float Health = 100;
    }
}
