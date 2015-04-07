namespace Models
{
    using System;
    using Models.CustomExceptions;
    using Models.Spells;
    using Models.Interfaces;

    public class Spell : ISpell
    {
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
                    throw new InvalidRangeException<int>("The name should be at least two charavters long!", 4);
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
            }
        }

        public override string ToString()
        {
            return string.Format("[{0} spell + {1} *{2}]",
                this.SpellName, this.SpellPoints, this.SpellType == SpellType.AttackSpell ? "AP" : "DP");
        } 
    }
}
