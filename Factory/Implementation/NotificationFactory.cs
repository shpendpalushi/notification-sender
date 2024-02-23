using webapi.Factory.Definition;
using webapi.Models.Commands;
using webapi.Models.Enums;
using webapi.Services.Definition;

namespace webapi.Factory.Implementation;

public class NotificationFactory(IDictionary<NotificationType, INotificationStrategy> strategies) : INotificationFactory
{
    private readonly IDictionary<NotificationType, INotificationStrategy> strategies = strategies;

    public async Task CreateNotification(CreateNotificationCommand command)
    {
        if(this.strategies.TryGetValue(command.NotificationType, out var strategy))
        {
            await strategy.CreateNotification(command);
        }
        else 
        {
            throw new ArgumentException("Unknown notification type");
        }
    }

}