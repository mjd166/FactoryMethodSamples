namespace MessageSenderService
{
    public abstract class MessageSenderFactory
    {
        public abstract IMessageSender CreateSender();
        public void Send(string recipient, string message)
        {
            IMessageSender sender = CreateSender();
            sender.SendMessage(recipient, message);
        }
    }

    public class EmailSenderFactory : MessageSenderFactory
    {
        public override IMessageSender CreateSender()
        {
            return new EmailSender();
        }
    }

    public class SmsSenderFactory : MessageSenderFactory
    {
        public override IMessageSender CreateSender()
        {
            return new SmsSender();
        }
    }
}
