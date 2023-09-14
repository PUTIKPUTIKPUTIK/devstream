using Task2Reflection.Vehicles;

namespace Task2Reflection.Services;

public static class VehicleService
{
    public static IEnumerable<T> GetAllVehicles<T>() where T : Vehicle
    {
        var baseEntityType = typeof(T);
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany( assembly => assembly.GetTypes() )
            .Where
            (
                type => baseEntityType.IsAssignableFrom(type)
                        && (type.GetConstructor(Type.EmptyTypes) != null)
                        && !type.IsAbstract
            );

        foreach (var type in types)
        {
            yield return (T)Activator.CreateInstance(type);
        }
    }
}