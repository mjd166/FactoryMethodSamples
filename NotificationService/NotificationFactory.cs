namespace NotificationService
{
    public static class NotificationFactory
    {
        public static INotification CreateNotification(NotificationType type)
        {
            return type switch
            {
                NotificationType.Email => new EmailNotification(),
                NotificationType.Sms => new SmsNotification(),
                NotificationType.Push => new PushNotification(),
                _ => throw new ArgumentException("Invalid notification type")
            };
        }
    }
}
