namespace Models.Interfaces
{
    using System.Collections.Generic;

    using Models.Creatures;
    using Models.Interfaces;

    public interface ICreature
    {
        int BaseHealth { get; set; }

        int BasePower { get; set; }

        GenderType Gender { get; }

        List<IItem> Items { get; }

        List<IWeapon> Weapons { get; }
    }
}
