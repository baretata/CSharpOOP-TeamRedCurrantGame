namespace Models.Spells.Interfaces
{
    public interface ISpell
    {
        string SpellName { get; }

        int SpellPoints { get; }

        SpellType SpellType { get; }

        //static int PowerEffect { get; }
        //static int HealingEffect { get; }
    }
}
