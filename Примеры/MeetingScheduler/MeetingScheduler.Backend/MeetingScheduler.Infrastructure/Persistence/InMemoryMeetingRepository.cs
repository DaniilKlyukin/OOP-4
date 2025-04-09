using MeetingScheduler.Application.Interfaces.Persistence;
using MeetingScheduler.Domain.Models;
using System.Collections.Concurrent;

namespace MeetingScheduler.Infrastructure.Persistence;

public class InMemoryMeetingRepository : IMeetingRepository
{
    private readonly ConcurrentDictionary<Guid, Meeting> _meetings = new();

    public Task AddAsync(Meeting meeting)
    {
        _meetings.TryAdd(meeting.Id, meeting);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Guid id)
    {
        _meetings.TryRemove(id, out _);
        return Task.CompletedTask;
    }

    public Task<Meeting?> GetByIdAsync(Guid id)
        => Task.FromResult(_meetings.TryGetValue(id, out var meeting) ? meeting : null);

    public Task<IEnumerable<Meeting>> GetByDateAsync(DateTime date)
        => Task.FromResult(_meetings.Values
            .Where(m => m.StartTime.Date == date.Date)
            .OrderBy(m => m.StartTime)
            .AsEnumerable());

    public Task<IEnumerable<Meeting>> GetUpcomingMeetingsAsync()
        => Task.FromResult(_meetings.Values
            .Where(m => m.StartTime >= DateTime.Now)
            .OrderBy(m => m.StartTime)
            .AsEnumerable());

    public Task<IEnumerable<Meeting>> GetAll()
        => Task.FromResult(_meetings.Values
            .OrderBy(m => m.StartTime)
            .AsEnumerable());

    public Task UpdateAsync(Meeting meeting)
    {
        _meetings[meeting.Id] = meeting;
        return Task.CompletedTask;
    }

    public Task<bool> HasOverlappingMeetingsAsync(DateTime start, DateTime end, Guid? excludeId = null)
    {
        var query = _meetings.Values.Where(m =>
            m.StartTime < end &&
            m.EndTime > start);

        if (excludeId.HasValue)
            query = query.Where(m => m.Id != excludeId.Value);

        return Task.FromResult(query.Any());
    }
}
