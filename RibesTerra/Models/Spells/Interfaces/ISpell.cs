namespace Models.Spells.Interfaces
{
    public interface ISpell
    {
<<<<<<< HEAD
        string SpellName { get; private set; }

        int SpellPoints { get; private set; }

        SpellType SpellType { get; set; }
=======
        SpellType TypeOfSpell { get; }
        public static int PowerEffect { get; }
        public static int HealingEffect { get; }
>>>>>>> 5f0ca40bdcf8737ffd2bad27fc5dd78155a4ada2
    }
}
