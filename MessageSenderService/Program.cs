using MessageSenderService;

var client = new MessageClient();

MessageSenderFactory factory = new EmailSenderFactory();
client.Send(factory, "mghafari41@yahoo.com", "hello this is factory method design pattern sample");

MessageSenderFactory smsfactory = new SmsSenderFactory();
client.Send(smsfactory, "09011739395", "hello this is facotyr method design pattern sample");