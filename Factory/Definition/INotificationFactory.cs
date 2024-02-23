
using webapi.Models.Commands;

namespace webapi.Factory.Definition;

public interface INotificationFactory
{
    // We could add some return type to make sure that notification was handled properly by the service provider
    Task CreateNotification(CreateNotificationCommand command);
}