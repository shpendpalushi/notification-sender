using webapi.Models.Enums;
using webapi.Services.Implementation;

namespace webapi.Configuration;
public static class NotificationTypeStrategyMapping
{
    public static Dictionary<Type, NotificationType> TypeMappings = new Dictionary<Type, NotificationType>
    {
        { typeof(EmailNotificationStrategy), NotificationType.Email },
        { typeof(SMSNotificationStrategy), NotificationType.SMS },
        { typeof(PushNotificationStrategy), NotificationType.PushNotification }
    };
}