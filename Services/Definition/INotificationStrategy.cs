using webapi.Models.Commands;

namespace webapi.Services.Definition;

public interface INotificationStrategy
{
    Task CreateNotification(CreateNotificationCommand command);
}