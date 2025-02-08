namespace DesignPatterns_Console.FactoryMethod.VehicleSystem.Products;

public class Car : IVehicle
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by Car");
    }
}