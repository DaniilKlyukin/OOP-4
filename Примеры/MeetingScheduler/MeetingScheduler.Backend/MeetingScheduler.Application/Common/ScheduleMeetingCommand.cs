namespace MeetingScheduler.Application.Common;

public record ScheduleMeetingCommand(
    string Title,
    string Description,
    DateTime StartTime,
    DateTime EndTime,
    Guid OrganizerId,
    TimeSpan? NotificationTime = null);
