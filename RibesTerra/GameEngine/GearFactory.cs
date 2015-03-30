namespace GameEngine
{
    using System;
using Models.Gear.Interfaces;

    public class GearFactory
    {
        public IGear CreateItem(string initialName, decimal initialPrice, int initialDefensePoints);

        public IGear CreateWeapon(string initialName, decimal initialPrice, int initialAttackPoints);

    }
}
