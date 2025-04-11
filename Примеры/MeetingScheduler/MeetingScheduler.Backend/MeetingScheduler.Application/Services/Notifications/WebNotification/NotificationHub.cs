using Microsoft.AspNetCore.SignalR;

namespace MeetingScheduler.Application.Services.Notifications.WebNotification;

public class NotificationHub : Hub
{

    public async Task SubscribeToNotifications(string groupName)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        await Clients.Caller.SendAsync("ReceiveNotification",
            new { Message = $"Вы подписались на уведомления группы {groupName}" });
    }

    public async Task SendNotificationToUser(string userId, string message)
    {
        await Clients.User(userId).SendAsync("ReceiveNotification",
            new { Message = message, Timestamp = DateTime.UtcNow });
    }
}