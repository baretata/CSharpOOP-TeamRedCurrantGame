namespace Models.Spells.Interfaces
{
    public interface ISpell
    {
        SpellType TypeOfSpell { get; }
        public static int PowerEffect { get; }
        public static int HealingEffect { get; }
    }
}
