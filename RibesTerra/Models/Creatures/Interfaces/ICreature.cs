namespace Models.Creatures.Interfaces
{
    using System.Collections.Generic;

    using Models.Gear.Interfaces;

    public interface ICreature
    {
        int BaseHealth { get; }

        int BasePower { get; }

        GenderType Gender { get; }

        HashSet<IGear> GearItems { get; }
    }
}
