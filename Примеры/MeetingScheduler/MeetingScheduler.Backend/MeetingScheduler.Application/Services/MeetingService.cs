using MeetingScheduler.Application.Interfaces.Persistence;
using MeetingScheduler.Application.Interfaces.Services;
using MeetingScheduler.Domain.Models;

namespace MeetingScheduler.Application.Services;

public class MeetingService : IMeetingService
{
    private readonly IMeetingRepository _repository;
    private readonly INotificationService _notificationService;
    private readonly IExportService _exportService;

    public MeetingService(
        IMeetingRepository repository,
        INotificationService notificationService,
        IExportService exportService)
    {
        _repository = repository;
        _notificationService = notificationService;
        _exportService = exportService;
    }

    public async Task EnableNotificationsAsync()
    {
        await _notificationService.StartPeriodicCheckingAsync();
    }

    public async Task DisableNotificationsAsync()
    {
        await _notificationService.StopPeriodicCheckingAsync();
    }

    public async Task<Meeting> ScheduleMeetingAsync(
        string title,
        string description,
        DateTime startTime,
        DateTime endTime,
        TimeSpan? notificationTime = null)
    {
        if (await _repository.HasOverlappingMeetingsAsync(startTime, endTime))
            throw new InvalidOperationException("Временной интервал уже занят");

        var meeting = new Meeting(title, description, startTime, endTime, notificationTime);
        await _repository.AddAsync(meeting);
        return meeting;
    }

    public async Task UpdateMeetingAsync(
        Guid meetingId,
        string title,
        string description,
        DateTime startTime,
        DateTime endTime,
        TimeSpan? notificationTime = null)
    {
        var meeting = await _repository.GetByIdAsync(meetingId)
            ?? throw new KeyNotFoundException("Встреча не найдена");

        if (await _repository.HasOverlappingMeetingsAsync(startTime, endTime, meetingId))
            throw new InvalidOperationException("Временной интервал уже занят");

        meeting.UpdateDetails(title, description);
        meeting.Reschedule(startTime, endTime);
        meeting.SetNotification(notificationTime);

        await _repository.UpdateAsync(meeting);
    }

    public async Task DeleteMeetingAsync(Guid meetingId)
    {
        await _repository.DeleteAsync(meetingId);
    }

    public async Task<IEnumerable<Meeting>> GetDailyScheduleAsync(DateTime date)
    {
        return await _repository.GetByDateAsync(date);
    }

    public async Task ExportDailyScheduleAsync(DateTime date, string filePath)
    {
        var meetings = await _repository.GetByDateAsync(date);
        await _exportService.ExportToFileAsync(meetings, filePath);
    }

    public async Task<IEnumerable<Meeting>> GetAllMeetings()
    {
        return await _repository.GetAll();
    }
}