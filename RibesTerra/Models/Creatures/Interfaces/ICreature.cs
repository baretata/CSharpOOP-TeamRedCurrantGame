namespace Models.Creatures.Interfaces
{
    using System.Collections.Generic;

    using Models.Gear.Interfaces;

    public interface ICreature
    {
        GenderType Gender { get; private set; }

        List<IGear> Inventory { get; private set; }
    }
}
