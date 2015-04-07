namespace Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Models.Creatures;
    using Models.Interfaces;
    using System.Text;
    using System.Globalization;

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

        public int CalculateAttackPoints(List<IWeapon> weaponList)
        {
            return weaponList.Sum(w => w.AttackPoints);       
        }

        public int CalculateDefensePoints(List<IItem> itemList)
        {
            return itemList.Sum(i => i.DefensePoints);
        }

        protected void AddSpell(Spell spellToAdd)
        {
            this.spellList.Add(spellToAdd);
        }

        public int CompareTo(ICreature other)
        {
            var currentCreatureOverallStats = this.BaseHealth + this.BasePower;
            var otherCreatureOverallStats = other.BaseHealth + other.BasePower;

            return currentCreatureOverallStats.CompareTo(otherCreatureOverallStats); // -1 if other wins, 1 if curr win 
        }

         public override string ToString()
        {
            StringBuilder creatureInfo = new StringBuilder();
            creatureInfo.AppendFormat(
                CultureInfo.InvariantCulture,
                "{0} (AP:{1}; DP:{2}; HP:{3}; GEN:{4})",
                this.GetType().Name,
                CalculateAttackPoints(this.Weapons),
                CalculateDefensePoints(this.Items),
                this.BaseHealth,
                this.Gender);

            creatureInfo.Append(" [");
            foreach (var weapon in this.Weapons)
            {
                creatureInfo.AppendFormat("{0},", weapon);
            }

            foreach (var item in this.Items)
            {
                creatureInfo.AppendFormat("{0},", item);
            }

            var result = creatureInfo.ToString().TrimEnd(',');
            result += "]";

            return result;
        }
    }
}
