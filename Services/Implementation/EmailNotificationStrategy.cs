using webapi.Models.Commands;
using webapi.Services.Definition;

namespace webapi.Services.Implementation;

public class EmailNotificationStrategy : INotificationStrategy
{
    public async Task CreateNotification(CreateNotificationCommand command)
    {
        // Implement email notification logic using the details from command
        // e.g., send an email using an email service like SendGrid or SMTP
        throw new NotImplementedException("Email: This method is to be implemented and is here just to show the concept");
    }
}