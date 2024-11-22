namespace TestDI.Notification
{
    public class EmailNotificationStrategy : INotificationStrategy
    {
        public string Key => "Email";   // 이메일 전략에 대한 고유 키 
        public void Send(string message) => Console.WriteLine($"Email sent: {message} ");
    }

}