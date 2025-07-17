using FactoryMethod.NotificationSystem.Products;

namespace FactoryMethod.NotificationSystem.Factories;

public class PushNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        return new PushNotification();
    }
}