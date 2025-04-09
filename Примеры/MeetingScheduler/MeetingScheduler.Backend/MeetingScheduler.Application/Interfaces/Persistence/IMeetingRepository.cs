using MeetingScheduler.Domain.Models;

namespace MeetingScheduler.Application.Interfaces.Persistence;

public interface IMeetingRepository
{
    Task<Meeting?> GetByIdAsync(Guid id);
    Task<IEnumerable<Meeting>> GetByDateAsync(DateTime date);
    Task<IEnumerable<Meeting>> GetAll();
    Task<IEnumerable<Meeting>> GetUpcomingMeetingsAsync();
    Task AddAsync(Meeting meeting);
    Task UpdateAsync(Meeting meeting);
    Task DeleteAsync(Guid id);
    Task<bool> HasOverlappingMeetingsAsync(
        DateTime start,
        DateTime end, 
        Guid? excludeId = null);
}
