namespace Models
{
    using System;
    using Models.Creatures;
    using Models.Creatures.Interfaces;

    public class Enemy : Creature, ICreature
    {
        public const int InitialEnemyAttack = 50;
        public const int InitialEnemyHealth = 100;

        public Enemy(string name, int power, int health, GenderType gender)
            : base(name, Enemy.InitialEnemyAttack, Enemy.InitialEnemyHealth, gender)
        {
        }
    }
}
