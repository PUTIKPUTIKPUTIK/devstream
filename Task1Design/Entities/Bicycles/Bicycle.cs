using Task1Design.Vehicles;

namespace Task1Design.Bicycles;

public class Bicycle : Vehicle
{
    public Bicycle(string name, int weight, string type, int maxSpeed = 50)
    {
        Name = name;
        Weight = weight;
        Type = type;
        MaxSpeed = maxSpeed;
    }

    public string Type { get; protected set; }
}