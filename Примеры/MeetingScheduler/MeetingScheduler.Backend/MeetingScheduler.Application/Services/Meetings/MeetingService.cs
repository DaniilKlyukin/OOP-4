using MeetingScheduler.Application.Common;
using MeetingScheduler.Application.Interfaces.Persistence;
using MeetingScheduler.Application.Interfaces.Services;
using MeetingScheduler.Domain.Models;

namespace MeetingScheduler.Application.Services.Meetings;

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

    public async Task<Meeting> ScheduleMeetingAsync(ScheduleMeetingCommand command)
    {
        if (await _repository.HasOverlappingMeetingsAsync(command.StartTime, command.EndTime))
            throw new InvalidOperationException("Временной интервал уже занят");

        var meeting = new Meeting(
            command.Title,
            command.Description,
            command.StartTime,
            command.EndTime,
            command.OrganizerId,
            command.NotificationTime);

        await _repository.AddAsync(meeting);
        return meeting;
    }

    public async Task UpdateMeetingAsync(UpdateMeetingCommand command)
    {
        var meeting = await _repository.GetByIdAsync(command.MeetingId)
            ?? throw new KeyNotFoundException("Встреча не найдена");

        if (await _repository.HasOverlappingMeetingsAsync(command.StartTime, command.EndTime, command.MeetingId))
            throw new InvalidOperationException("Временной интервал уже занят");

        meeting.UpdateDetails(command.Title, command.Description);
        meeting.Reschedule(command.StartTime, command.EndTime);
        meeting.SetNotification(command.NotificationTime);

        await _repository.UpdateAsync(meeting);
    }

    public async Task DeleteMeetingAsync(DeleteMeetingCommand command)
    {
        await _repository.DeleteAsync(command.MeetingId);
    }

    public async Task<IEnumerable<Meeting>> GetDailyScheduleAsync(GetDailyScheduleQuery query)
    {
        return await _repository.GetByDateAsync(query.Date);
    }

    public async Task ExportDailyScheduleAsync(ExportDailyScheduleCommand command)
    {
        var meetings = await _repository.GetByDateAsync(command.Date);
        await _exportService.ExportToFileAsync(meetings, command.FilePath);
    }

    public async Task<IEnumerable<Meeting>> GetAllMeetings()
    {
        return await _repository.GetAll();
    }
}