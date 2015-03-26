namespace Models
{
    using System;

    using Models.Spells;
    using Models.Spells.Interfaces;

    public class Spell : ISpell
    {
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
            }
        }
    }
}
