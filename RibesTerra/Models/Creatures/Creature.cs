namespace Models
{
    using System;
    using System.Collections.Generic;

    using Models.Creatures;
    using Models.Creatures.Interfaces;
    using Models.Gear.Interfaces;

    public abstract class Creature : GameObject, ICreature, IComparable
    {
        public Creature(string name, decimal gold, int power, int health, GenderType gender)
            : base(name, gold, power, health)
        {
            this.Gender = gender;
        }

        public GenderType Gender { get; private set; }

        public List<IGear> Inventory { get; private set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
