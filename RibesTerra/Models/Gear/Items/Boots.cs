namespace Models.Gear.Items
{
    using System;

    using Models.Gear.Interfaces;

    public class Boots : Gear, IGear, IItem
    {
        private int defensePoints;
        private double speed;

        public Boots(string initialName, decimal initialPrice, string initialDescription, int initialDefencePoints, double initialSpeed)
            : base(initialName, initialPrice, initialDescription)
        {
            this.DefensePoints = initialDefencePoints;
            this.Speed = initialSpeed;
        }

        public int DefensePoints
        {
            get
            {
                return this.defensePoints;
            }
            protected set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Defense points cannot be less or equal to zero!");
                }
                this.defensePoints = value;
            }
        }

        public double Speed
        {
            get
            {
                return this.speed;
            }
            protected set
            {
                if (value < 0 || value == 0)
                {
                    throw new ArgumentException("Speed cannot be less or equal to zero!");
                }
                this.speed = value;
            }
        }
    }
}
