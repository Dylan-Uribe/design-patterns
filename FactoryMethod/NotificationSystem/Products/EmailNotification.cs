namespace FactoryMethod.NotificationSystem.Products;

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Email notification: {message}");
    }
}