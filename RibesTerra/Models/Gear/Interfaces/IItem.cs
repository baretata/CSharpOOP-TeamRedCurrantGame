namespace Models.Gear.Interfaces
{
    public interface IItem : IGear
    {
        int DefensePoints { get; protected set; }
    }
}
