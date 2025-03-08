namespace MessageSenderService
{
    public interface IMessageSender
    {
        void SendMessage(string recipient,string message);
    }
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string recipient, string message)
        {
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
        }
    }
}
