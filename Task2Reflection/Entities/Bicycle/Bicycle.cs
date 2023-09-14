using Task2Reflection.Vehicles;

namespace Task2Reflection.Bicycles;

public class Bicycle : Vehicle
{
    public Bicycle()
    {
        Name = "Aist";
        Weight = 20;
        Type = "gornik";
        MaxSpeed = 30;
    }
    
    public Bicycle(string name, int weight, string type, int maxSpeed = 50)
    {
        Name = name;
        Weight = weight;
        Type = type;
        MaxSpeed = maxSpeed;
    }

    public string Type { get; protected set; }
}