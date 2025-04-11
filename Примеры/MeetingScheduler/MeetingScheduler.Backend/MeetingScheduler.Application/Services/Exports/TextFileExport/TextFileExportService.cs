using MeetingScheduler.Application.Interfaces.Services;
using MeetingScheduler.Domain.Models;

namespace MeetingScheduler.Application.Services.Exports.TextFileExport;

public class TextFileExportService : IExportService
{
    public async Task ExportToFileAsync(IEnumerable<Meeting> meetings, string filePath)
    {
        var content = string.Join(Environment.NewLine, meetings.Select(m =>
            $"{m.StartTime:t}-{m.EndTime:t}: {m.Title} - {m.Description}"));

        await File.WriteAllTextAsync(filePath, content);
    }
}