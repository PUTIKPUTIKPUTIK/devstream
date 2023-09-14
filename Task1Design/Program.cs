using Task1Design.Bicycles;
using Task1Design.Cars;

namespace Task1Design
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("BMW", 2500);
            var carWithMaxSpeed = new Car("Audi", 3000, 300);
            var bicycle = new Bicycle("Aist", 20, "gornik");
            
            Console.WriteLine($"{car.Name}|{car.Weight}|{car.MaxSpeed}");
            Console.WriteLine($"{carWithMaxSpeed.Name}|{carWithMaxSpeed.Weight}|{carWithMaxSpeed.MaxSpeed}");
            Console.WriteLine($"{bicycle.Name}|{bicycle.Weight}|{bicycle.Type}|{bicycle.MaxSpeed}");
        }
    }
}