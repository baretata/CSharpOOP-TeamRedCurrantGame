namespace Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using Models.Creatures;
    using Models.Interfaces;

    public abstract class Creature : GameObject, ICreature, IComparable<ICreature>
    {
        private readonly ICollection<ISpell> spellList;

        public Creature(string name, int power, int health, GenderType gender)
            : base(name)
        {
            this.BaseHealth = health;
            this.BasePower = power;
            this.Gender = gender;
            this.Items = new List<IItem>();
            this.Weapons = new List<IWeapon>();
            this.spellList = new List<ISpell>();
        }

        public int BaseHealth { get; set; }

        public int BasePower { get; set; }

        public GenderType Gender { get; private set; }

        public List<IItem> Items { get; private set; }

        public List<IWeapon> Weapons { get; private set; }

        protected void AddItemsList(List<IItem> itemList)
        {
            foreach (var item in itemList)
            {
                this.Items.Add(item);
            }
        }

        protected void AddWeaponList(List<IWeapon> weaponList)
        {
            foreach (var item in weaponList)
            {
                this.Weapons.Add(item);
            }
        }

        protected void AddSpecialty(Spell spellToAdd)
        {
            this.spellList.Add(spellToAdd);
        }

        public int CompareTo(ICreature other)
        {
            var currentCreatureOverallStats = this.BaseHealth + this.BasePower;
            var otherCreatureOverallStats = other.BaseHealth + other.BasePower;

            return currentCreatureOverallStats.CompareTo(otherCreatureOverallStats); // -1 if other wins, 1 if curr win 
        }
    }
}
