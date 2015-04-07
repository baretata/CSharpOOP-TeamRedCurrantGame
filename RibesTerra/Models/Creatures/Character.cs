namespace Models
{
    using System;

    using Models.Creatures;
    using Models.Interfaces;

    public class Character : Creature, ICreature, ICharacter
    {
        public const decimal InitialCharacterGold = 100;
        public const int InitialCharacterAttack = 50;
        public const int InitialCharacterHealth = 50;

        public Character(string name, GenderType gender)
            : base(name, Character.InitialCharacterAttack, Character.InitialCharacterHealth, gender)
        {
            this.GoldAmount = InitialCharacterGold;
        }

        public decimal GoldAmount { get; private set; }

        public void UseSpell()
        {
            throw new NotImplementedException();
        }
    }
}
