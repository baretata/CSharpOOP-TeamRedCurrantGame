namespace GameEngine.Interfaces
{
    using System;

    using Models;
    using Models.Creatures;
    using Models.Creatures.Interfaces;

    public interface ICreatureFactory
    {
        ICharacter CreateCharacter(string name, int power, int health, string gender, decimal gold);

        ICreature CreateEasyEnemy(string name, int power, int health, string gender);

        ICreature CreateHardEnemy(string name, int power, int health, string gender);
    }
}
