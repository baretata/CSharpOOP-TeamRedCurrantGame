namespace Models.Gear.Interfaces
{
    public interface IGear
    {
        string Name { get; }

        decimal Price { get; }

        string Description { get; }

        double Weight { get; }
    }
}
