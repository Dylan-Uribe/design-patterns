using DesignPatterns_Console.FactoryMethod.VehicleSystem.Products;

namespace DesignPatterns_Console.FactoryMethod.VehicleSystem.Factories;

public abstract class VehicleFactory
{
    public abstract IVehicle CreateVehicle();
}