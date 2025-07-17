using FactoryMethod.NotificationSystem.Products;

namespace FactoryMethod.NotificationSystem.Factories;

public abstract class NotificationCreator
{
    protected abstract INotification CreateNotification();
    
    public void Notify(string message)
    {
        var notification = CreateNotification();
        notification.Send(message);
    }
}