namespace Models.Gear
{
    using System;
    using Models.Gear.Interfaces;

    public abstract class Gear : GameObject, IGear
    {
        private string name;
        private decimal price;
        private string description;
        private double weight;

        public Gear(string initialName, decimal initialPrice, string initialDescription, double initialWeight) 
            : base(initialName)
        {
            this.Weight = initialWeight;
            this.Price = initialPrice;
            this.Description = initialDescription;
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            protected set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Weight cannot be less or equal to zero!");
                }
                this.weight = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 4)
                {
                    throw new ArgumentException("Name cannot be less than 4 characters or empty!");
                }
                this.name = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Price cannot be less or equal to zero!");
                }
                this.price = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Description cannot be null or empty");
                }
                this.description = value;
            }
        }
    }
}
