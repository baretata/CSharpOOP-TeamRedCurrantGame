namespace Models
{
    using System;
    using System.Collections.Generic;

    using Models.CustomExceptions;

    public abstract class GameObject         //Main class parent of all models
    {
        private string name;

        public GameObject(string name, int power, int health)
        {
            this.Name = name;
        }

        public GameObject(string initialName)
        {
            this.Name = initialName;
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
                    throw new InvalidRangeException<int>("Name cannot be less than 4 characters or empty!", 4);
                }
                this.name = value;
            }
        }
    }
}
