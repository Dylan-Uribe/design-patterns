using DesignPatterns_Console.FactoryMethod.VehicleSystem.Products;

namespace DesignPatterns_Console.FactoryMethod.VehicleSystem.Factories;

public class DroneFactory : VehicleFactory
{
    public override IVehicle CreateVehicle() => new Drone();
}