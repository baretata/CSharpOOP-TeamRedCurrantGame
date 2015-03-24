namespace Models
{
    using System;
    
    using Models.Creatures.Interfaces;

    public abstract class Creature : GameObject, ICreature, IComparable
    {
        public void Attack()
        {
            throw new NotImplementedException();
        }
        
        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public string AttackPoints
        {
            get { throw new NotImplementedException(); }
        }

        public Creatures.GenderType Gender
        {
            get { throw new NotImplementedException(); }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
