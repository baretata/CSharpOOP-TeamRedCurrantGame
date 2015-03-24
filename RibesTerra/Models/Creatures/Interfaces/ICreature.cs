namespace Models.Creatures.Interfaces
{
    public interface ICreature
    {
        public string Name { get; private set; }

        public string AttackPoints { get; private set; }

        public GenderType Gender { get; private set; }

        void Attack();
    }
}
