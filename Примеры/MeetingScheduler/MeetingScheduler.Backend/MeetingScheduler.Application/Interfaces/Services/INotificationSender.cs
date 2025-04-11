using MeetingScheduler.Application.Common;

namespace MeetingScheduler.Application.Interfaces.Services;

public interface INotificationSender
{
    Task SendNotificationAsync(SendNotificationCommand command);
}