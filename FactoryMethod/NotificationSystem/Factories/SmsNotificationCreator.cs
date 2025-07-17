using FactoryMethod.NotificationSystem.Products;

namespace FactoryMethod.NotificationSystem.Factories;

public class SmsNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        return new SmsNotification();
    }
}