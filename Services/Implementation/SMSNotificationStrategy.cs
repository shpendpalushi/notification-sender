using webapi.Models.Commands;
using webapi.Services.Definition;

namespace webapi.Services.Implementation;

public class SMSNotificationStrategy : INotificationStrategy
{
    public async Task CreateNotification(CreateNotificationCommand command)
    {
        // Implement SMS notification logic using the details from command
        // e.g., send an SMS using a third-party SMS gateway
        throw new NotImplementedException("SMS: This method is to be implemented and is here just to show the concept");
    }
}