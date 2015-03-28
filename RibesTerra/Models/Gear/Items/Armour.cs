﻿namespace Models.Gear.Items
{
    using System;
    using Models.Gear.Interfaces;

    public class Armour : Gear, IGear, IItem
    {
        private int defensePoints;

        public Armour(string initialName, decimal initialPrice, string initialDescription, int initialDefensePoints)
            : base(initialName, initialPrice, initialDescription)
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
                    throw new ArgumentException("Defense points cannot be less or equal to zero!");
                }
                this.defensePoints = value;
            }
        }
    }
}
