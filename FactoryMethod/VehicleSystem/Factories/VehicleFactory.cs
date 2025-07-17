using FactoryMethod.VehicleSystem.Products;

namespace FactoryMethod.VehicleSystem.Factories;

public abstract class VehicleFactory
{
    public abstract IVehicle CreateVehicle();
}