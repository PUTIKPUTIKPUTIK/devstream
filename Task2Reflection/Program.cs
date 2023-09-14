using Task2Reflection.Services;
using Task2Reflection.Vehicles;

namespace Task2Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = VehicleService.GetAllVehicles<Vehicle>().ToArray();

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Name} {vehicle.MaxSpeed} {vehicle.GetType()}");
            }
        }
    }
}