namespace MessageSenderService
{
    public class MessageClient
    {
        public void Send(MessageSenderFactory senderFactory,string recipient, string message)
        {
            senderFactory.Send(recipient, message);
        }
    }
}
