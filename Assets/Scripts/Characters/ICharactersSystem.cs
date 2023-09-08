using System;

namespace DeeppTest.Characters
{
    public interface ICharactersSystem
    {
        void SpawnCharacter(SpawnDataModel spawnData);

        void UpdateAmmoCounter(int amount);
    }
}
