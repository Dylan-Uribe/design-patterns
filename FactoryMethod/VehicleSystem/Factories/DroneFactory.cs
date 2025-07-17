using FactoryMethod.VehicleSystem.Products;

namespace FactoryMethod.VehicleSystem.Factories;

public class DroneFactory : VehicleFactory
{
    public override IVehicle CreateVehicle() => new Drone();
}