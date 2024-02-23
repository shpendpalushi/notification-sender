using webapi.Models.Commands;
using webapi.Services.Definition;

namespace webapi.Services.Implementation;

public class PushNotificationStrategy : INotificationStrategy
{
    public async Task CreateNotification(CreateNotificationCommand command)
    {
        // Implement push notification logic using the details from command
        // e.g., send a push notification using a service like Firebase Cloud Messaging (FCM) or Azure Notification Hubs
        throw new NotImplementedException("Push Notification: This method is to be implemented and is here just to show the concept");
    }
}