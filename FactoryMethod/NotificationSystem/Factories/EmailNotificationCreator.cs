using FactoryMethod.NotificationSystem.Products;

namespace FactoryMethod.NotificationSystem.Factories;

public class EmailNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}