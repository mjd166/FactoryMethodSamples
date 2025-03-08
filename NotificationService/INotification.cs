namespace NotificationService
{
    public interface INotification
    {
        void Send(string message);
    }
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Send email notification {message}");
        }
    }
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"send SMS notification {message}");
        }
    }

    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"send  push notfication {message}");
        }
    }
}
