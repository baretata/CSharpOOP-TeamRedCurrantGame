namespace GameEngine.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Models.Gear.Interfaces;

    public interface IGearFactory
    {
        IList<IItem> CreateItemSet(string initialName, decimal initialPrice, double initialWeight, int initialDefensePoints);

        IList<IWeapon> CreateWeaponSet(string initialName, decimal initialPrice, double initialWeight, int initialAttackPoints);
    }
}
