namespace Models.Gear.Weapons
{
    using System;

    using Models.Gear.Interfaces;

    public class Sword : Weapon, IGear, IWeapon
    {
        public Sword(string initialName, decimal initialPrice, string initialDescription, double initialWeight, int initialAttackPoints)
            : base(initialName, initialPrice, initialDescription, initialWeight, initialAttackPoints)
        {
        }

        public Sword(string initialName, decimal initialPrice, int attackPoints)
            : base(initialName, initialPrice, attackPoints)
        {
        }
    }
}
