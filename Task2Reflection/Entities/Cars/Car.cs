using Task2Reflection.Vehicles;

namespace Task2Reflection.Cars;

public class Car : Vehicle
{
    public Car()
    {
        Name = "Audi";
        Weight = 2000;
        MaxSpeed = 300;
    }
    
    public Car(string name, int weight, int maxSpeed = 200)
    {
        Name = name;
        Weight = weight;
        MaxSpeed = maxSpeed;
    }
}