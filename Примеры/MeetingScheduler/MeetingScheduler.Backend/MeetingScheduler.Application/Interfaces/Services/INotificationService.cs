using MeetingScheduler.Domain.Models;

namespace MeetingScheduler.Application.Interfaces.Services;

public interface INotificationService
{
    Task NotifyAsync(Meeting meeting);
    Task CheckAndSendNotificationsAsync();
    Task StartPeriodicCheckingAsync(TimeSpan? interval = null);
    Task StopPeriodicCheckingAsync();
}