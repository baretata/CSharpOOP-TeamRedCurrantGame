namespace Models.Gear.Items
{
    using System;
    using Models.CustomExceptions;
    using Models.Gear.Interfaces;

    public abstract class Item : Gear, IGear, IItem
    {
        private int defensePoints;

        public Item(string initialName, decimal initialPrice, int initialDefensePoints)
            : base(initialName, initialPrice)
        {
            this.DefensePoints = initialDefensePoints;
        }

        public Item(string initialName, decimal initialPrice, string initialDescription, double initialWeight, int initialDefensePoints)
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
                if (value <= 0)
                {
                    throw new InvalidRangeException<int>("Defense points cannot be less or equal to zero!", 0);
                }

                this.defensePoints = value;
            }
        }
    }
}
