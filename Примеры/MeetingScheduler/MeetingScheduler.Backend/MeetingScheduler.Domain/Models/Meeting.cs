namespace MeetingScheduler.Domain.Models;

public class Meeting : IEquatable<Meeting>
{
    public Guid Id { get; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime StartTime { get; private set; }
    public DateTime EndTime { get; private set; }
    public TimeSpan? NotificationTime { get; private set; }
    public bool NotificationSent { get; private set; }
    public Guid OrganizerId { get; private set; }

    public Meeting(
        string title,
        string description,
        DateTime startTime,
        DateTime endTime,
        Guid organizerId,
        TimeSpan? notificationTime = null)
    {
        ValidateTimeRange(startTime, endTime);

        Id = Guid.NewGuid();
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Description = description ?? string.Empty;
        StartTime = startTime;
        EndTime = endTime;
        NotificationTime = notificationTime;
        NotificationSent = false;
        OrganizerId = organizerId;
    }

    public void UpdateDetails(string title, string description)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Description = description ?? string.Empty;
    }

    public void Reschedule(DateTime newStartTime, DateTime newEndTime)
    {
        ValidateTimeRange(newStartTime, newEndTime);
        StartTime = newStartTime;
        EndTime = newEndTime;
        NotificationSent = false;
    }

    public void SetNotification(TimeSpan? notificationTime)
    {
        NotificationTime = notificationTime;
        NotificationSent = false;
    }

    public void MarkNotificationAsSent() => NotificationSent = true;

    private static void ValidateTimeRange(DateTime start, DateTime end)
    {
        if (start >= end)
            throw new ArgumentException("Время окончания должно быть позже времени начала");

        if (start < DateTime.Now)
            throw new ArgumentException("Не удалось запланировать встречи в прошлом");
    }

    public bool Equals(Meeting? other) => Id == other?.Id;
    public override bool Equals(object? obj) => Equals(obj as Meeting);
    public override int GetHashCode() => Id.GetHashCode();
}
