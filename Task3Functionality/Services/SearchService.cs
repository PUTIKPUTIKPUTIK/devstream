using Task3Functionality.Vehicles;

namespace Task3Functionality.Services;

public static class SearchService
{
    public static int Find(Vehicle[] source, string trigger)
    {
        if (string.IsNullOrWhiteSpace(trigger))
        {
            Console.WriteLine("You should specify a trigger");
            return 0;
        }
        
        var result = source.Where(vehicle => vehicle.Name.Contains(trigger)).ToArray();

        if (result.Length == 0)
        {
            Console.WriteLine("Nope");
            return 0;
        }

        foreach (var vehicle in result)
        {
            Console.WriteLine(vehicle.Name);
        }

        return result.Length;
    }
}