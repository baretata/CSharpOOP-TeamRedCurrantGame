namespace Models.Gear.Items
{
    using System;

    using Models.Gear.Interfaces;

    public class Helmet : Gear, IGear, IItem
    {
        public const int defensePower = 2;
        
        private int defensePoints;

        public Helmet(string initialName, decimal initialPrice, string initialDescription,double initialWeight, int initialDefensePoints)
            : base(initialName, initialPrice, initialDescription, initialWeight)
        {   // TODO: sth smarter 
            this.defensePoints = initialDefensePoints * defensePower; 
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
    }
}
