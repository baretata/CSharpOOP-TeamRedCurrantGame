namespace Models.Gear.Weapons
{
    using System;

    using Models.Gear.Interfaces;

    public class Sword : Gear, IGear, IWeapon
    {
        private int attackPoints;

        public Sword(string initialName, decimal initialPrice, string initialDescription, double initialWeight, int initialAttackPoints)
            : base(initialName, initialPrice, initialDescription, initialWeight)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            protected set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Attack points cannot be less or equal to zero!");
                }
                this.attackPoints = value;
            }
        }
    }
}
