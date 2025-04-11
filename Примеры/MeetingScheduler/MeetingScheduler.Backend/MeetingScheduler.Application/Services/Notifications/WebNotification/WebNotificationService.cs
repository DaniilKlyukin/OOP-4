using MeetingScheduler.Application.Common;
using MeetingScheduler.Application.Interfaces.Persistence;
using MeetingScheduler.Application.Interfaces.Services;
using MeetingScheduler.Domain.Models;
using Microsoft.Extensions.Logging;

namespace MeetingScheduler.Application.Services.Notifications.WebNotification;

public class WebNotificationService : INotificationService
{
    private readonly IMeetingRepository _repository;
    private readonly Timer _timer;
    private readonly INotificationSender _notificationSender;
    private readonly ILogger<WebNotificationService> _logger;

    public WebNotificationService(
        IMeetingRepository repository,
        INotificationSender notificationSender,
        ILogger<WebNotificationService> logger)
    {
        _repository = repository;
        _notificationSender = notificationSender;
        _logger = logger;

        _timer = new Timer(async (obj) => await CheckNotifications(obj), null, Timeout.Infinite, Timeout.Infinite);

        StartPeriodicCheckingAsync();
    }

    public Task StartPeriodicCheckingAsync(TimeSpan? interval = null)
    {
        var _interval = interval ?? TimeSpan.FromMinutes(1);

        _timer.Change(TimeSpan.Zero, _interval);
        _logger.LogInformation($"Запущена периодическая проверка уведомлений с интервалом {_interval}");

        return Task.CompletedTask;
    }

    public Task StopPeriodicCheckingAsync()
    {
        _timer.Change(Timeout.Infinite, Timeout.Infinite);
        _logger.LogInformation("Остановлена проверка периодических уведомлений");
        return Task.CompletedTask;
    }

    private async Task CheckNotifications(object? state)
    {
        try
        {
            await CheckAndSendNotificationsAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Произошла ошибка при проверке уведомлений");
        }
    }

    public async Task CheckAndSendNotificationsAsync()
    {
        _logger.LogDebug("Проверка наличия предстоящих собраний, требующих уведомления");

        var upcomingMeetings = await _repository.GetUpcomingMeetingsAsync();
        var now = DateTime.Now;

        foreach (var meeting in upcomingMeetings)
        {
            try
            {
                if (meeting.NotificationTime.HasValue &&
                    !meeting.NotificationSent &&
                    meeting.StartTime.Subtract(meeting.NotificationTime.Value) <= now)
                {
                    await NotifyAsync(meeting);
                    meeting.MarkNotificationAsSent();
                    await _repository.UpdateAsync(meeting);

                    _logger.LogInformation($"Отправлено уведомление о проведении собрания {meeting.Id}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Произошла ошибка при обработке собрания {meeting.Id}");
            }
        }
    }

    public async Task NotifyAsync(Meeting meeting)
    {
        var message = $"Встреча '{meeting.Title}' начинается в {meeting.StartTime:t}";

        try
        {
            var command = new SendNotificationCommand(meeting.OrganizerId,
                                                      "Напоминание о встрече",
                                                      message,
                                                      meeting.Id);

            await _notificationSender.SendNotificationAsync(command);

            _logger.LogDebug($"Успешно отправлено уведомление о проведении собрания {meeting.Id}");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Не удалось отправить уведомление о собрании {meeting.Id}");
            throw;
        }
    }
}
