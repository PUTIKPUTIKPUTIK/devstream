using Task1Design.Vehicles;

namespace Task1Design.Cars;

public class Car : Vehicle
{
    public Car(string name, int weight, int maxSpeed = 200)
    {
        Name = name;
        Weight = weight;
        MaxSpeed = maxSpeed;
    }
}