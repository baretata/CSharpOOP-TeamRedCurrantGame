namespace Models
{
    using System;
    using System.Collections.Generic;

    using Models.Creatures;
    using Models.Creatures.Interfaces;
    using Models.Gear.Interfaces;

    public abstract class Creature : GameObject, ICreature, IComparable
    {
        public Creature(string name, int power, int health, GenderType gender)
            : base(name, power, health)
        {
            this.BaseHealth = health;
            this.BasePower = power;
            this.Gender = gender;
            this.GearItems = new List<IGear>();
        }

        public int BaseHealth { get; private set; }

        public int BasePower { get; private set; }

        public GenderType Gender { get; private set; }

        public List<IGear> GearItems { get; private set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

    }
}
