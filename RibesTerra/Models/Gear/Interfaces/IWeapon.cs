namespace Models.Gear.Interfaces
{
    public interface IWeapon : IGear
    {
        int AttackPoints { get; protected set; }
    }
}
