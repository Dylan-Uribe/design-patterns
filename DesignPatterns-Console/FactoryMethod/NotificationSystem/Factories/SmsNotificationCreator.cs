using DesignPatterns_Console.FactoryMethod.NotificationSystem.Products;

namespace DesignPatterns_Console.FactoryMethod.NotificationSystem.Factories;

public class SmsNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        return new SmsNotification();
    }
}