namespace MeetingScheduler.Application.Common;

public record ExportDailyScheduleCommand(DateTime Date, string FilePath);
