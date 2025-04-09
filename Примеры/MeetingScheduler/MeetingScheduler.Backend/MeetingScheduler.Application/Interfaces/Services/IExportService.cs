using MeetingScheduler.Domain.Models;

namespace MeetingScheduler.Application.Interfaces.Services;

public interface IExportService
{
    Task ExportToFileAsync(IEnumerable<Meeting> meetings, string filePath);
}