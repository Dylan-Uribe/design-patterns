namespace FactoryMethod.VehicleSystem.Products;

public class Drone : IVehicle
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by Drone");
    }
}