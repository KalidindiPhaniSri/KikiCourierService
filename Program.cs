using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel
    .Debug()
    .WriteTo
    .Console()
    .WriteTo
    .File("logs/kiki-courier-.log", rollingInterval: RollingInterval.Day)
    .CreateLogger();

var services = new ServiceCollection();

services.AddLogging(builder =>
{
    builder.ClearProviders();
    builder.AddSerilog();
});

var serviceProvider = services.BuildServiceProvider();

var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

logger.LogInformation("Application started");
