using FactoryMethod.VehicleSystem.Products;

namespace FactoryMethod.VehicleSystem.Factories;

public class CarFactory : VehicleFactory
{
    public override IVehicle CreateVehicle() => new Car();
}