namespace EventHandlingAndDelegates
{
    public class NotificationService
    {
        public delegate void SendNotification(string recipient, string message);
        public void SendEmail(string recipient, string message)
        {
            Console.WriteLine($"Sending email to {recipient}: {message}");
            // Code to send email...
        }

        public void SendSMS(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
            // Code to send SMS...
        }

        public void SendPushNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending push notification to {recipient}: {message}");
            // Code to send push notification...
        }
    }
}
