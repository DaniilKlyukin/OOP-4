using MeetingScheduler.Application.Interfaces.Services;
using MeetingScheduler.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MeetingScheduler.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<INotificationService, ConsoleNotificationService>();
        services.AddScoped<IExportService, TextFileExportService>();
        services.AddScoped<MeetingService>();

        return services;
    }
}
