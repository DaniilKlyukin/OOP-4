using MeetingScheduler.Domain.Models;

namespace MeetingScheduler.Application.Interfaces.Services;

public interface IMeetingService
{
    Task DeleteMeetingAsync(
        Guid meetingId);

    Task ExportDailyScheduleAsync(
        DateTime date,
        string filePath);

    Task<IEnumerable<Meeting>> GetDailyScheduleAsync(
        DateTime date);

    Task<IEnumerable<Meeting>> GetAllMeetings();

    Task<Meeting> ScheduleMeetingAsync(
        string title,
        string description, 
        DateTime startTime,
        DateTime endTime,
        TimeSpan? notificationTime = null);

    Task UpdateMeetingAsync(
        Guid meetingId,
        string title,
        string description,
        DateTime startTime,
        DateTime endTime,
        TimeSpan? notificationTime = null);
}