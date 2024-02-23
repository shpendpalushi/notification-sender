using Microsoft.AspNetCore.Mvc;
using webapi.Factory.Definition;
using webapi.Models.Commands;

namespace webapi.Controllers;
[Route("/api/messages")]
[ApiController]

public class NotificationController(INotificationFactory notificationFactory) : ControllerBase
{
    private readonly INotificationFactory notificationFactory = notificationFactory;

    [HttpPost("send")]
    public async Task<IActionResult> SendMessage([FromBody] CreateNotificationCommand command)
    {
        await this.notificationFactory.CreateNotification(command);
        return this.Ok();
    }
}