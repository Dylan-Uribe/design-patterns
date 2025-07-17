using FactoryMethod.VehicleSystem.Factories;
using FactoryMethod.VehicleSystem.Products;

namespace FactoryMethod.VehicleSystem.Client;

public abstract class Vehicle
{
    public static void Run()
    {
        VehicleFactory carFactory = new CarFactory();
        IVehicle car = carFactory.CreateVehicle();
        car.Deliver();
        
        VehicleFactory bikeFactory = new BikeFactory();
        IVehicle bike = bikeFactory.CreateVehicle();
        bike.Deliver();
        
        VehicleFactory droneFactory = new DroneFactory();
        IVehicle drone = droneFactory.CreateVehicle();
        drone.Deliver();
    }
}