using FactoryMethod.NotificationSystem.Factories;

namespace FactoryMethod.NotificationSystem.Client;

public abstract class Notification
{
    public static void Run()
    {
        NotificationCreator emailCreator = new EmailNotificationCreator();
        emailCreator.Notify("Email message content.");

        NotificationCreator smsCreator = new SmsNotificationCreator();
        smsCreator.Notify("SMS message content.");

        NotificationCreator pushCreator = new PushNotificationCreator();
        pushCreator.Notify("Push message content.");
    }
}