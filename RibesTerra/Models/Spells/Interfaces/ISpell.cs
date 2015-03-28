namespace Models.Spells.Interfaces
{
    public interface ISpell
    {
        string SpellName { get; private set; }

        int SpellPoints { get; private set; }

        SpellType SpellType { get; set; }
    }
}
