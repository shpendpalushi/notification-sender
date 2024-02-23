using System.Net;
using webapi.Models.DTO;

namespace webapi.Middleware;
public class ExceptionMiddleware(ILogger<ExceptionMiddleware> logger, IWebHostEnvironment environment) : IMiddleware
{
    private readonly ILogger<ExceptionMiddleware> logger = logger;
    private readonly IWebHostEnvironment environment = environment;


    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception e)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";
            string errorUuid = Guid.NewGuid().ToString();
            string message;
            if (!environment.IsDevelopment())
            {
                message = $"Internal error, a note in the system logs has been left with the id: {errorUuid}";
                logger.LogError($"{errorUuid}::Exception message:: " + e.Message + "::Inner exception::" + e.InnerException?.Message);
            }
            else
            {
                message = "::Exception message:: " + e.Message + "::Inner exception::" + e.InnerException?.Message;
            }
            await context.Response.WriteAsync(new ExceptionDTO()
            {
                Code = context.Response.StatusCode,
                Messages = [message]
            }.ToString());
        }
    }
}
