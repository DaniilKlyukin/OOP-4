namespace MeetingScheduler.Application.Common;

public record UpdateMeetingCommand(
    Guid MeetingId,
    string Title,
    string Description,
    DateTime StartTime,
    DateTime EndTime,
    TimeSpan? NotificationTime = null);
