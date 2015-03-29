namespace Models.Creatures.Interfaces
{
    using System.Collections.Generic;

    using Models.Gear.Interfaces;

    public interface ICreature
    {
        public GenderType Gender { get; private set; }

        public List<IGear> Inventory { get; private set; }
    }
}
