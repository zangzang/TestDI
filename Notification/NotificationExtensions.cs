namespace TestDI.Notification
{
    public static class NotificationExtensions
    {
        public static IServiceCollection AddNotification(this IServiceCollection services)
        {
            services.AddTransient<INotificationStrategy, EmailNotificationStrategy>();
            services.AddTransient<INotificationStrategy, SmsNotificationStrategy>();
            services.AddSingleton<NotificationFactory>();
            services.AddSingleton<NotificationService>();
            return services;
        }
    }
}