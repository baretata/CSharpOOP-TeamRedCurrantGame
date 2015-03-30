namespace Models.Gear.Weapons
{
    using System;

    using Models.Gear.Interfaces;

    public class Staff : Gear, IGear, IWeapon
    {
        public const int MaxConstructPieces = 5;

        private int attackPoints;

        private int constructPieces;

        public Staff(string initialName, decimal initialPrice, string initialDescription, double initialWeight, int initialAttackPoints, int initialConstructPieces)
            : base(initialName, initialPrice, initialDescription, initialWeight)
        {
            this.AttackPoints = initialAttackPoints;
            this.ConstructPieces = initialConstructPieces;
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

        public int ConstructPieces
        {
            get
            {
                return this.constructPieces;
            }
            protected set
            {
                if (value < 0 || value == 0)
                {
                    throw new ArgumentException("Construct pieces cannot be less or equal to zero!");
                }
                if (value > MaxConstructPieces)
                {
                    throw new ArgumentException("Construct pieces cannot be more than 5");
                }
                this.constructPieces = value;
            }
        }
    }
}
