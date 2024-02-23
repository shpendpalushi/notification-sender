

using webapi.Configuration;
using webapi.Factory.Definition;
using webapi.Factory.Implementation;
using webapi.Middleware;
using webapi.Services.Definition;
using webapi.Services.Implementation;

var builder = WebApplication.CreateBuilder(args);
// Register your notification strategies
builder.Services.AddTransient<INotificationStrategy, EmailNotificationStrategy>();
builder.Services.AddTransient<INotificationStrategy, SMSNotificationStrategy>();
builder.Services.AddTransient<INotificationStrategy, PushNotificationStrategy>();

// Register the NotificationFactory with a dictionary of strategies
builder.Services.AddTransient<INotificationFactory>(provider =>
{
    var strategies = provider.GetServices<INotificationStrategy>()
        .ToDictionary(strategy => NotificationTypeStrategyMapping.TypeMappings.GetValueOrDefault(strategy.GetType()), strategy => strategy);
    
    return new NotificationFactory(strategies);
});
// Register middlewares
builder.Services.AddScoped<ExceptionMiddleware>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "Just a health check endpoint");

app.MapControllers();
app.UseMiddleware<ExceptionMiddleware>();
app.Run();
