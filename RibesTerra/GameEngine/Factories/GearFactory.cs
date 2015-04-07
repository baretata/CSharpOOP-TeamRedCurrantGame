namespace GameEngine.Factories
{
    using System;
    using System.Collections.Generic;
    using Models.CustomExceptions;
    using Models.Gear;
    using Models.Interfaces;
    using Models.Gear.Items;
    using Models.Gear.Weapons;
    using Models.Extensions;

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
                        new Armour(initialName, initialPrice, null, initialWeight, initialDefensePoints);
                        break;
                    case ItemType.Boots:
                        new Boots(initialName, initialPrice, null, initialWeight, initialDefensePoints, RandomGenerator.Instance.Next(0, 21));
                        break;
                    case ItemType.Gloves:
                        new Boots(initialName, initialPrice, null, initialWeight, initialDefensePoints, RandomGenerator.Instance.Next(0, 21));
                        break;
                    case ItemType.Helmet:
                        new Helmet(initialName, initialPrice, null, initialWeight, initialDefensePoints);
                        break;
                    default:
                        throw new InvalidRangeException<IItem>("Item does not exist");
                }
            }

            return itemSet;
        }

        public IList<IWeapon> CreateWeaponSet(string initialName, decimal initialPrice, double initialWeight, int initialAttackPoints)
        {
            var weaponSet = new List<IWeapon>();

            foreach (var weaponType in (WeaponType[])Enum.GetValues(typeof(WeaponType)))
            {
                switch (weaponType)
                {
                    case WeaponType.Bow:
                        new Bow(initialName, initialPrice, null, initialWeight, initialAttackPoints, Bow.MaxArrowAmount);
                        break;
                    case WeaponType.Staff:
                        new Staff(initialName, initialPrice, null, initialWeight, initialAttackPoints, Staff.MaxConstructPieces);
                        break;
                    case WeaponType.Sword:
                        new Sword(initialName, initialPrice, null, initialWeight, initialAttackPoints);
                        break;
                    default:
                        throw new InvalidRangeException<IItem>("Weapon does not exist");
                }
            }

            return weaponSet;
        }
    }
}
