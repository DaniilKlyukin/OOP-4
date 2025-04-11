using MeetingScheduler.Application.Common;
using MeetingScheduler.Domain.Models;

namespace MeetingScheduler.Application.Interfaces.Services;

public interface IMeetingService
{
    Task DeleteMeetingAsync(DeleteMeetingCommand command);

    Task ExportDailyScheduleAsync(ExportDailyScheduleCommand command);

    Task<IEnumerable<Meeting>> GetDailyScheduleAsync(GetDailyScheduleQuery query);

    Task<IEnumerable<Meeting>> GetAllMeetings();

    Task<Meeting> ScheduleMeetingAsync(ScheduleMeetingCommand command);

    Task UpdateMeetingAsync(UpdateMeetingCommand command);
}