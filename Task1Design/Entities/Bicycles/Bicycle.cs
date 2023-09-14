using Task1Design.Vehicles;

namespace Task1Design.Bicycles;

public class Bicycle : Vehicle
{
    public Bicycle()
    {
        Name = "Audi";
        Weight = 2000;
        Type = "gornik";
        MaxSpeed = 300;
    }

    public string Type { get; protected set; }
}