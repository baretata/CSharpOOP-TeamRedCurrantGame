namespace Models.Gear.Weapons
{
    using System;
    using Models.Gear.Interfaces;

    public class Axe : Weapon, IGear, IWeapon
    {
        public Axe(string initialName, decimal initialPrice, string initialDescription, double initialWeight, int initialAttackPoints)
            : base(initialName, initialPrice, initialDescription, initialWeight, initialAttackPoints)
        {
        }

        public Axe(string initialName, decimal initialPrice, int initialAttackPoints)
            : base(initialName, initialPrice, initialAttackPoints)
        {
        }
    }
}
