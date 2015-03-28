namespace Models
{
    using System;

    using Models.Spells;
    using Models.Spells.Interfaces;

    public class Spell : ISpell
    {
<<<<<<< HEAD
        private string spellName;
        private int spellPoints;
        private SpellType spellType;

        public Spell(string spellName, int spellPoints, SpellType spellType)
        {
            this.SpellName = spellName;
            this.SpellPoints = spellPoints;
            this.SpellType = spellType;
        }

        public string SpellName
        {
            get
            {
                return this.spellName;
            }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The name should be at least two charavters long!");
                }

                this.spellName = value;
            }
        }

        public int SpellPoints
        {
            get
            {
                return this.spellPoints;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Points of the spell should have a positive value!");
                }

                this.spellPoints = value;
            }
        }

        public SpellType SpellType
        {
            get
            {
                return this.spellType;
            }
            private set
            {
                this.spellType = value;
=======
        internal const int SpellEffectQuantity = 50;

        public Spell(SpellType spellType)
        {
            this.TypeOfSpell = spellType;
        }

        public SpellType TypeOfSpell { get; private set; }

        public static int PowerEffect 
        {
            get
            {
                return Spell.SpellEffectQuantity;      //spell will take 50 health to enemy
            }
        }

        public static int HealingEffect
        {
            get
            {
                return Spell.SpellEffectQuantity;      //spell will add 50 health to our character
>>>>>>> 5f0ca40bdcf8737ffd2bad27fc5dd78155a4ada2
            }
        }
    }
}
