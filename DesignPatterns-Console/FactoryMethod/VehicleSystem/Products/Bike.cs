namespace DesignPatterns_Console.FactoryMethod.VehicleSystem.Products;

public class Bike : IVehicle
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by Bike");
    }
}