using MeetingScheduler.Application.Common;
using MeetingScheduler.Application.Interfaces.Services;
using Microsoft.AspNetCore.SignalR;

namespace MeetingScheduler.Application.Services.Notifications.WebNotification;

public class SignalRNotificationSender : INotificationSender
{
    private readonly IHubContext<NotificationHub> _hubContext;

    public SignalRNotificationSender(IHubContext<NotificationHub> hubContext)
    {
        _hubContext = hubContext;
    }

    public async Task SendNotificationAsync(SendNotificationCommand command)
    {
        await _hubContext.Clients.User(command.userId.ToString()).SendAsync("ReceiveNotification", new
        {
            Title = command.title,
            Message = command.message,
            MeetingId = command.meetingId,
            Timestamp = DateTime.UtcNow
        });
    }
}
