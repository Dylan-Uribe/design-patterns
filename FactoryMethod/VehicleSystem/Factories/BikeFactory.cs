using FactoryMethod.VehicleSystem.Products;

namespace FactoryMethod.VehicleSystem.Factories;

public class BikeFactory : VehicleFactory
{
    public override IVehicle CreateVehicle() => new Bike();
}