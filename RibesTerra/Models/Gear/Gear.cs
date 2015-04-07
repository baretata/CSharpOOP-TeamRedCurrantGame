namespace Models.Gear
{
    using System;
    using Models.CustomExceptions;
    using Models.Interfaces;

    public abstract class Gear : GameObject, IGear
    {
        public const double InitialGearWeight = 10;

        private decimal price;
        private string description;
        private double weight;

        public Gear(string initialName, decimal initialPrice)
            : base(initialName)
        {
            this.Price = initialPrice;
        }

        public Gear(string initialName, decimal initialPrice, string initialDescription, double initialWeight)
            : this(initialName, initialPrice)
        {
            this.Description = initialDescription;
            this.Weight = Gear.InitialGearWeight;
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new InvalidRangeException<int>("Price cannot be less or equal to zero!", 0);
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
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidRangeException<int>("Description cannot be null or empty", 0);
                }
                this.description = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new InvalidRangeException<double>("Weight cannot be less or equal to zero!", 0);
                }
                this.weight = value;
            }
        }

    }
}
