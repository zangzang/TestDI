namespace TestDI.Notification
{
    public class SmsNotificationStrategy : INotificationStrategy
    {
        public string Key => "SMS";   // SMS 전략에 대한 고유 키 
        public void Send(string message) => Console.WriteLine($"SMS sent: {message} ");
    }

}