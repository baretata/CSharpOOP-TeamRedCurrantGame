namespace Models
{
    using System;

    using Models.Creatures;
    using Models.Creatures.Interfaces;

    public class Character : Creature, ICreature, ICharacter
    {
        public const decimal InitialCharacterGold = 100;
        public const int InitialCharacterAttack = 50;
        public const int InitialCharacterHealth = 100;

        public Character(string name, int attack, int health, GenderType gender, decimal gold)
            : base(name, Character.InitialCharacterAttack, Character.InitialCharacterHealth, gender)
        {
            this.GoldAmount = InitialCharacterGold;
        }

        public decimal GoldAmount { get; protected set; }

        public void UseSpell()
        {
            throw new NotImplementedException();
        }
    }
}
