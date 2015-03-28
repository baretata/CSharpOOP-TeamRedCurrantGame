namespace Models
{
    using System;
    using System.Collections.Generic;

    public abstract class GameObject         //Main class parent of all models
    {
        public string Name { get; private set; }

        public decimal GoldAmount { get; protected set; }

        public int BasePower { get; protected set; }

        public int BaseHealth { get; protected set; }

        public GameObject(string initialName)
        {
            this.Name = initialName;
        }

        public GameObject(string name, decimal gold, int power, int health)
        {
            this.Name = name;
            this.GoldAmount = gold;
            this.BasePower = power;
            this.BaseHealth = health;
        }
    }
}
