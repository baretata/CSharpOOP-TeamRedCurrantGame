namespace GameEngine.Factories
{
    using System;
    using System.Collections.Generic;

    using GameEngine;
    using GameEngine.Interfaces;
    using Models;
    using Models.Creatures;
    using Models.Creatures.Interfaces;

    public class CreatureFactory : ICreatureFactory
    {
        public ICharacter CreateCharacter(string name, int power, int health, string gender, decimal gold)
        {
            return new Character(name, Character.InitialCharacterAttack, Character.InitialCharacterHealth,
                GenderType.Male, Character.InitialCharacterGold);
        }

        public ICreature CreateEasyEnemy(string name, int power, int health, string gender)
        {
            return new Enemy(
                name,
                Enemy.InitialEnemyAttack + Engine.rnd.Next(0, 20),
                Enemy.InitialEnemyHealth + Engine.rnd.Next(0, 20),
                (GenderType)Engine.rnd.Next(0, 2));
        }

        public ICreature CreateHardEnemy(string name, int power, int health, string gender)
        {
            return new Enemy(
                   name,
                   Enemy.InitialEnemyAttack + Engine.rnd.Next(30, 50),
                   Enemy.InitialEnemyHealth + Engine.rnd.Next(30, 50),
                   (GenderType)Engine.rnd.Next(0, 2));
        }
    }
}
