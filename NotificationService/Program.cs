using NotificationService;

var emailnotifier = NotificationFactory.CreateNotification( NotificationType.Email);
emailnotifier.Send("hello your order is received.");

var smsNotifier = NotificationFactory.CreateNotification( NotificationType.Sms);
smsNotifier.Send("hello your order received.");

Console.ReadLine();