using UnityEngine;

using DeeppTest.PlayerInput;
using DeeppTest.Weapons;
using DeeppTest.UI;

namespace DeeppTest.Characters
{
    public enum CharacterType
    {
        None,
        Player,
        Enemy,
        Dummy
    }

    public class CharactersSystem : MonoBehaviour, ICharactersSystem
    {
        [SerializeField]
        private GameObject playerInputReference;
        [SerializeField]
        private GameObject weaponsReference;
        [SerializeField]
        private GameObject uIReference;

        [SerializeField]
        private CharacterDatabase characterDatabase;
        [SerializeField]
        private PlayerSettingsData playerSettings;

        private IPlayerInputSystem playerInput;
        private IWeaponsSystem weapons;
        private IUISystem uI;

        private CharacterControllersFactory characterControllersFactory;

        private IPlayerController playerController;

        private void Awake()
        {
            playerInput = playerInputReference.GetComponent<IPlayerInputSystem>();
            weapons = weaponsReference.GetComponent<IWeaponsSystem>();
            uI = uIReference.GetComponent<IUISystem>();
            characterControllersFactory = new();
        }

        private void OnEnable()
        {
            playerInput.MovementEvent += OnMovementEvent;
            playerInput.LookEvent += OnLookEvent;
            playerInput.FireEvent += OnFireEvent;
        }

        private void OnDisable()
        {
            playerInput.MovementEvent -= OnMovementEvent;
            playerInput.LookEvent -= OnLookEvent;
            playerInput.FireEvent -= OnFireEvent;
        }

        public void SpawnCharacter(SpawnDataModel spawnData)
        {
            IWeapon weapon;

            switch (spawnData.CharacterType)
            {
                case CharacterType.Player:
                    if (playerController == null)
                    {
                        weapon = weapons.GetWeapon();

                        playerController = characterControllersFactory.CreatePlayerController(
                            characterDatabase.PlayerData, 
                            spawnData, 
                            transform,
                            playerSettings,
                            weapon,
                            this
                            );
                    }
                    break;

                case CharacterType.Enemy:
                    weapon = weapons.GetWeapon();
                    characterControllersFactory.CreateEnemyController(
                        characterDatabase.EnemyData, 
                        spawnData, 
                        transform,
                        weapon
                        );
                    break;

                case CharacterType.Dummy:
                    characterControllersFactory.CreateDummyController(
                        characterDatabase.DummyData, 
                        spawnData, 
                        transform
                        );
                    break;
            }
        }

        private void OnMovementEvent(Vector2 value)
        {
            playerController.MoveUpdate(value);
        }

        private void OnLookEvent(Vector2 value)
        {
            playerController.LookUpdate(value);
        }

        private void OnFireEvent()
        {
            playerController.FireUpdate();
        }

        public void UpdateAmmoCounter(int amount)
        {
            uI.UpdateAmmoCounter(amount);
        }
    }
}
