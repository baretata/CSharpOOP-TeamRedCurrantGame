namespace Models.Gear.Interfaces
{
    public interface IGear
    {
        string Name { get; set; }

        decimal Price { get; set; }

        string Description { get; set; }

        double Weight { get; set; }
    }
}
