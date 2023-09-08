using UnityEngine;

namespace DeeppTest.Characters
{
    [CreateAssetMenu(fileName = "PlayerSettingsData", menuName = "Game Data/Player Settings Data")]
    public class PlayerSettingsData : ScriptableObject
    {
        public float CameraSensitivity = 25f;
    }
}
