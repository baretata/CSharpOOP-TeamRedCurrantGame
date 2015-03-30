namespace Models.Gear.Items
{
    using System;
    using Models.Gear.Interfaces;

    class Axe : Gear, IGear, IWeapon
    {
        private int attackPoints;

        public Axe(string initialName, decimal initialPrice, string initialDescription, double initialWeight, int initialAttackPoints)
            : base(initialName, initialPrice, initialDescription, initialWeight)
        {

        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Attack points cannot be less or equal to zero!");
                }

                this.attackPoints = value;
            }
        }
    }
}
