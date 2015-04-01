namespace GameEngine.Factories
{
    using System;
    using System.Collections.Generic;
    using GameEngine.Interfaces;
    using Models.CustomExceptions;
    using Models.Gear;
    using Models.Gear.Interfaces;
    using Models.Gear.Items;
    using Models.Gear.Weapons;

    public class GearFactory : IGearFactory
    {
        public IList<IItem> CreateItemSet(string initialName, decimal initialPrice, double initialWeight, int initialDefensePoints)
        {
            var itemSet = new List<IItem>();

            foreach (var itemType in (ItemType[])Enum.GetValues(typeof(ItemType)))
            {
                switch (itemType)
                {
                    case ItemType.Armour:
                        new Armour(initialName, initialPrice + Engine.rnd.Next(0, 21), null, initialWeight + Engine.rnd.Next(0, 21), initialDefensePoints + Engine.rnd.Next(0, 21));
                        break;
                    case ItemType.Boots:
                        new Boots(initialName, initialPrice + Engine.rnd.Next(0, 21), null, initialWeight + Engine.rnd.Next(0, 21), initialDefensePoints + Engine.rnd.Next(0, 21), Engine.rnd.Next(0, 21));
                        break;
                    case ItemType.Gloves:
                        new Boots(initialName, initialPrice + Engine.rnd.Next(0, 21), null, initialWeight + Engine.rnd.Next(0, 21), initialDefensePoints + Engine.rnd.Next(0, 21), Engine.rnd.Next(0, 21));
                        break;
                    case ItemType.Helmet:
                        new Helmet(initialName, initialPrice + Engine.rnd.Next(0, 21), null, initialWeight + Engine.rnd.Next(0, 21), initialDefensePoints + Engine.rnd.Next(0, 21));
                        break;
                    default:
                        throw new InvalidRangeException<IItem>("Item does not exist");
                }
            }

            return itemSet;

            //return new List<IItem> 
            //{
            //    new Armour(initialName,initialPrice + Engine.rnd.Next(0,21), null,initialWeight + Engine.rnd.Next(0,21), initialDefensePoints + Engine.rnd.Next(0,21)),
            //    new Boots(initialName, initialPrice + Engine.rnd.Next(0,21), null,initialWeight + Engine.rnd.Next(0,21), initialDefensePoints + Engine.rnd.Next(0,21), Engine.rnd.Next(0,21)),
            //    new Gloves(initialName, initialPrice + Engine.rnd.Next(0,21),null,initialWeight + Engine.rnd.Next(0,21), initialDefensePoints + Engine.rnd.Next(0,21), Engine.rnd.Next(0,21)),
            //    new Helmet(initialName, initialPrice + Engine.rnd.Next(0,21),null,initialWeight + Engine.rnd.Next(0,21), initialDefensePoints + Engine.rnd.Next(0,21))
            //};
        }

        public IList<IWeapon> CreateWeaponSet(string initialName, decimal initialPrice, double initialWeight, int initialAttackPoints)
        {
            return new List<IWeapon> 
            {
                new Bow(initialName, initialPrice + Engine.rnd.Next(0,21),null, initialWeight + Engine.rnd.Next(0,21), initialAttackPoints + Engine.rnd.Next(0,21),Bow.MaxArrowAmount),
                new Staff(initialName, initialPrice + Engine.rnd.Next(0,21),null, initialWeight + Engine.rnd.Next(0,21), initialAttackPoints + Engine.rnd.Next(0,21),Staff.MaxConstructPieces),
                new Sword(initialName, initialPrice + Engine.rnd.Next(0,21),null, initialWeight + Engine.rnd.Next(0,21), initialAttackPoints + Engine.rnd.Next(0,21))
            };
        }
    }
}
