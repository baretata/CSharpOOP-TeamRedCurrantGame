namespace Models.Gear.Items
{
    using System;

    using Models.Gear.Interfaces;

    public class Gloves : Gear, IGear, IItem
    {
        private int defensePoints;
        private int agilityPoints;

        public Gloves(string initialName, decimal initialPrice, string initialDescription, int initialDefensePoints, int initialAgilityPoints) 
            :base(initialName,initialPrice,initialDescription)
        {
            this.DefensePoints = initialDefensePoints;
            this.AgilityPoints = initialAgilityPoints;
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

        public int AgilityPoints
        {
            get
            {
                return this.agilityPoints;
            }
            protected set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Agility poins cannot be less or equal to zero!");
                }
                this.agilityPoints = value;
            }
        }

    }
}
