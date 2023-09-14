using Task1Design.Bicycles;
using Task1Design.Cars;

namespace Task1Design
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var carWithMaxSpeed = new Car();
            var bicycle = new Bicycle();
            
            Console.WriteLine($"{car.Name}|{car.Weight}|{car.MaxSpeed}");
            Console.WriteLine($"{carWithMaxSpeed.Name}|{carWithMaxSpeed.Weight}|{carWithMaxSpeed.MaxSpeed}");
            Console.WriteLine($"{bicycle.Name}|{bicycle.Weight}|{bicycle.Type}|{bicycle.MaxSpeed}");
        }
    }
}