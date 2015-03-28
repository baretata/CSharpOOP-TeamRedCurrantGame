namespace Models.Gear.Weapons
{
    using System;

    using Models.Gear.Interfaces;

    public class Bow : Gear, IGear, IWeapon
    {
        private int attackPoints;
        private int arrowAmount;

        public Bow(string initialName, decimal initialPrice, string initialDescription, double initialWeight, int initialAttackPoints, int initialArrowAmount)
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
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Attack points cannot be less or equal to zero!");
                }
                this.attackPoints = value;
            }
        }

        public int ArrowAmount
        {
            get
            {
                return this.arrowAmount;
            }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Arrow amount cannot be less or equal to zero!");
                }
                if (value > 10)
                {
                    throw new ArgumentException("Arrow amount cannot be more than ten!");
                }
                this.arrowAmount = value;
            }
        }

    }
}
