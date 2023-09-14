using Task3Functionality.Vehicles;

namespace Task3Functionality.Services;

public static class AlphabetService
{
    public static void ShowAlphabeticOrder<T>(T[] source) where T : Vehicle
    {
        var sorted = source
            .OrderBy(vehicle => vehicle.Name)
            .Select(vehicle => vehicle.Name)
            .ToArray();

        foreach (var vehicle in sorted)
        {
            Console.WriteLine(vehicle);
        }
    }
}