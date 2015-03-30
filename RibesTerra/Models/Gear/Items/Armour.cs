namespace Models.Gear.Items
{
    using System;
    using Models.CustomExceptions;
    using Models.Gear.Interfaces;

    public class Armour : Gear, IGear, IItem
    {
        private int defensePoints;

        public Armour(string initialName, decimal initialPrice, string initialDescription, double initialWeight, int initialDefensePoints)
            : base(initialName, initialPrice, initialDescription, initialWeight)
        {
            this.DefensePoints = initialDefensePoints;
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
                    throw new InvalidRangeException<int>("Defense points cannot be less or equal to zero!", 0);
                }
                this.defensePoints = value;
            }
        }
    }
}
