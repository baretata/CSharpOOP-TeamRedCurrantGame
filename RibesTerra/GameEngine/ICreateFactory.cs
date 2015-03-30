namespace GameEngine
{
    using System;

    using Models;
    using Models.Creatures;
    using Models.Creatures.Interfaces;

    public interface ICreatureFactory
    {
        ICharacter CreateCharacter(string name, int power, int health, string gender, decimal gold);

        ICreature CreateEnemy(string name, int power, int health, string gender);
    }
}
