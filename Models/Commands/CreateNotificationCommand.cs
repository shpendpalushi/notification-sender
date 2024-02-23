using webapi.Models.Enums;

namespace webapi.Models.Commands;

public class CreateNotificationCommand
{
    public NotificationType NotificationType { get; set; }
    public required string To { get; set; }
    public required string Subject { get; set; }

}