using MeetingScheduler.Application.Interfaces.Services;
using MeetingScheduler.Application.Services.Exports.TextFileExport;
using MeetingScheduler.Application.Services.Meetings;
using MeetingScheduler.Application.Services.Notifications.ConsoleNotification;
using MeetingScheduler.Application.Services.Notifications.WebNotification;
using Microsoft.Extensions.DependencyInjection;

namespace MeetingScheduler.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        //services.AddScoped<INotificationService, WebNotificationService>();
        //services.AddScoped<INotificationSender, SignalRNotificationSender>();

        services.AddScoped<INotificationService, ConsoleNotificationService>();
        services.AddScoped<IExportService, TextFileExportService>();
        services.AddScoped<MeetingService>();

        return services;
    }
}
