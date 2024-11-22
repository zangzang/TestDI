namespace TestDI.Notification
{
    public class NotificationService(NotificationFactory factory)
    {
        private readonly NotificationFactory _factory = factory;

        public (bool IsOK, string message) SendNotification(string type, string message)
        {
            var strategy = _factory.GetStrategy(type);
            strategy.Send(message);
            return (true, "Notification sent successfully");
        }
    }
}