using DesignPatterns_Console.FactoryMethod.NotificationSystem.Products;

namespace DesignPatterns_Console.FactoryMethod.NotificationSystem.Factories;

public class PushNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        return new PushNotification();
    }
}