using DayOfWeek = EduTrack.Domain.Enums.DayOfWeek;

namespace EduTrack.Persistence.DataAccess.Entities;

public class Schedule
{
    public Guid Id { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }

    public Guid CabinetId { get; set; }
    public Cabinet Cabinet { get; set; }

    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; }

    public Guid GroupId { get; set; }
    public Group Group { get; set; }

    public Guid TeacherId { get; set; }
    public Teacher Teacher { get; set; }
}