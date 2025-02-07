using DesignPatterns_Console.FactoryMethod.NotificationSystem.Products;

namespace DesignPatterns_Console.FactoryMethod.NotificationSystem.Factories;

public class EmailNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}