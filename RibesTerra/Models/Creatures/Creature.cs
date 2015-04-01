namespace Models
{
    using System;
    using System.Collections.Generic;

    using Models.Creatures;
    using Models.Creatures.Interfaces;
    using Models.Gear.Interfaces;

    public abstract class Creature : GameObject, ICreature, IComparable<ICreature>
    {
        public Creature(string name, int power, int health, GenderType gender)
            : base(name)
        {
            this.BaseHealth = health;
            this.BasePower = power;
            this.Gender = gender;
            this.GearItems = new HashSet<IGear>();
        }

        public int BaseHealth { get; private set; }

        public int BasePower { get; private set; }

        public GenderType Gender { get; private set; }

        public HashSet<IGear> GearItems { get; private set; }

        public int CompareTo(ICreature other)
        {
            var currentCreatureOverallStats = this.BaseHealth + this.BasePower;
            var otherCreatureOverallStats = other.BaseHealth + other.BasePower;

            return currentCreatureOverallStats.CompareTo(otherCreatureOverallStats); // -1 if other wins, 1 if curr win 
        }
    }
}
