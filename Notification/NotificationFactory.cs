using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDI.Notification
{
    public class NotificationFactory
    {
        private readonly IEnumerable<INotificationStrategy> _strategies;

        public NotificationFactory(IEnumerable<INotificationStrategy> strategies)
        {
            _strategies = strategies;
        }

        public INotificationStrategy GetStrategy(string notificationType)
        {
            var strategy = _strategies.FirstOrDefault(s => s.Key == notificationType);
            return strategy ?? throw new ArgumentException("Invalid notification type");
        }
    }
}