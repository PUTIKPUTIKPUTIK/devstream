using Task3Functionality.Bicycles;
using Task3Functionality.Cars;
using Task3Functionality.Entities.Motorcycle;
using Task3Functionality.Services;
using Task3Functionality.Vehicles;

namespace Task3Functionality
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new Vehicle[]
            {
                new Car(),
                new Motorcycle(),
                new Bicycle(),
            };
            
            //Alphabetic order:
            
            Console.WriteLine("Without Order: ");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Name);
            }
            
            Console.WriteLine("With order: ");
            AlphabetService.ShowAlphabeticOrder(vehicles);

            //Search:
            
            int search = 0;
            while (search == 0)
            {
                Console.WriteLine("Enter your trigger to find some vehicles: ");
                var trigger = Console.ReadLine();
                search = SearchService.Find(vehicles, trigger);
            }
        }
    }
}