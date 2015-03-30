namespace GameEngine
{
    using System;
using Models.Gear.Interfaces;

    //TODO: Implement every gear class to return his instance

    public class GearFactory : IGearFactory
    {
        public IGear CreateItem(string initialName, decimal initialPrice, int initialDefensePoints)
        { 
        }

        public IGear CreateWeapon(string initialName, decimal initialPrice, int initialAttackPoints)
        { 
        
        }

    }
}
