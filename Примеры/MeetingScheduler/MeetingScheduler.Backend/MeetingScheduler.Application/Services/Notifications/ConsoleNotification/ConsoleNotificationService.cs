using MeetingScheduler.Application.Interfaces.Persistence;
using MeetingScheduler.Application.Interfaces.Services;
using MeetingScheduler.Domain.Models;

namespace MeetingScheduler.Application.Services.Notifications.ConsoleNotification;

public class ConsoleNotificationService : INotificationService
{
    private readonly IMeetingRepository _repository;
    private readonly Timer _timer;

    public ConsoleNotificationService(IMeetingRepository repository)
    {
        _repository = repository;

        _timer = new Timer(async (obj) => await CheckNotifications(obj), null, Timeout.Infinite, Timeout.Infinite);

        StartPeriodicCheckingAsync();
    }

    public Task StartPeriodicCheckingAsync(TimeSpan? interval = null)
    {
        _timer.Change(TimeSpan.Zero, interval ?? TimeSpan.FromMinutes(1));
        return Task.CompletedTask;
    }

    public Task StopPeriodicCheckingAsync()
    {
        _timer.Change(Timeout.Infinite, Timeout.Infinite);
        return Task.CompletedTask;
    }

    private async Task CheckNotifications(object? state)
    {
        await CheckAndSendNotificationsAsync();
    }

    public async Task CheckAndSendNotificationsAsync()
    {
        var upcomingMeetings = await _repository.GetUpcomingMeetingsAsync();
        var now = DateTime.Now;

        foreach (var meeting in upcomingMeetings)
        {
            if (meeting.NotificationTime.HasValue &&
                !meeting.NotificationSent &&
                meeting.StartTime.Subtract(meeting.NotificationTime.Value) <= now)
            {
                await NotifyAsync(meeting);
                meeting.MarkNotificationAsSent();
                await _repository.UpdateAsync(meeting);
            }
        }
    }

    public Task NotifyAsync(Meeting meeting)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\n[НАПОМИНАНИЕ] Встреча '{meeting.Title}' начинается в {meeting.StartTime:t}");
        Console.ResetColor();
        return Task.CompletedTask;
    }
}