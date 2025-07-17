namespace FactoryMethod.NotificationSystem.Products;

public class PushNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Push Notification: {message}");
    }
}