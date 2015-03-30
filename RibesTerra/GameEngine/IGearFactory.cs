namespace GameEngine
{
    using System;
    using Models.Gear.Interfaces;

    public interface IGearFactory
    {
        IGear CreateItem(string initialName, decimal initialPrice, int initialDefensePoints);

        IGear CreateWeapon(string initialName, decimal initialPrice, int initialAttackPoints);


    }
}
