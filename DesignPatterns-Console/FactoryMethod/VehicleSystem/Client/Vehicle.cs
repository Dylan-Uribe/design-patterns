using DesignPatterns_Console.FactoryMethod.VehicleSystem.Factories;
using DesignPatterns_Console.FactoryMethod.VehicleSystem.Products;

namespace DesignPatterns_Console.FactoryMethod.VehicleSystem.Client;

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