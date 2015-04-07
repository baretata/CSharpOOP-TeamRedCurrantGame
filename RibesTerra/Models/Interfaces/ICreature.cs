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

        ICollection<IItem> Items { get; }

        ICollection<IWeapon> Weapons { get; }

        //int CalculateDefensePoints(ICollection<IItem> itemList);

        //int CalculateAttackPoints(ICollection<IWeapon> weaponList);

        void AddSpell(Spell spellToAdd);
    }
}
