namespace Models
{
    using System;

    using Models.Creatures;
    using Models.Creatures.Interfaces;

    public class Character : Creature, ICreature, ICharacter
    {
        public const decimal characterGold = 100;
        public const int baseAttack = 50;
        public const int baseHealth = 100;

        public Character(string name, GenderType gender)
            : base(name, Character.characterGold, Character.baseAttack, Character.baseHealth, gender)
        { 
            
        }

        public void UseSpell()
        {
            throw new NotImplementedException();
        }
    }
}
