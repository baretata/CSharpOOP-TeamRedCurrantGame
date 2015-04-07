﻿namespace Models
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

        public ICollection<IItem> Items { get; private set; }

        public ICollection<IWeapon> Weapons { get; private set; }

        public void AddItemsList(List<IItem> itemList)
        {
            foreach (var item in itemList)
            {
                this.Items.Add(item);
            }
        }

        public void AddWeaponList(ICollection<IWeapon> weaponList)
        {
            foreach (var item in weaponList)
            {
                this.Weapons.Add(item);
            }
        }

        protected int CalculateAttackPoints(ICollection<IWeapon> weaponList)
        {
            return weaponList.Sum(w => w.AttackPoints);       
        }

        protected int CalculateDefensePoints(ICollection<IItem> itemList)
        {
            return itemList.Sum(i => i.DefensePoints);
        }

        public void AddSpell(Spell spellToAdd)
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
                this.Name,
                CalculateAttackPoints(this.Weapons) + this.BasePower,
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
             
            foreach (var item in this.spellList)
            {
                creatureInfo.AppendFormat(item.ToString());
            }

            var result = creatureInfo.ToString().TrimEnd(',');
            result += "]";

            return result;
        }
    }
}
