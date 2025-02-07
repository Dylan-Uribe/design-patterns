namespace DesignPatterns_Console.FactoryMethod.NotificationSystem.Products;

public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS Notification: {message}");
    }
}