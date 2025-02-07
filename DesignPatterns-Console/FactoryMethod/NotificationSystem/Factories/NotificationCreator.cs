using DesignPatterns_Console.FactoryMethod.NotificationSystem.Products;

namespace DesignPatterns_Console.FactoryMethod.NotificationSystem.Factories;

public abstract class NotificationCreator
{
    protected abstract INotification CreateNotification();
    
    public void Notify(string message)
    {
        var notification = CreateNotification();
        notification.Send(message);
    }
}