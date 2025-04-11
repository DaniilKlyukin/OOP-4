namespace MeetingScheduler.Application.Common;

public record SendNotificationCommand(Guid userId,
                                      string title,
                                      string message,
                                      Guid meetingId);
