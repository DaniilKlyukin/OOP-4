using DayOfWeek = EduTrack.Domain.Enums.DayOfWeek;

namespace EduTrack.Domain.Models;

public class Schedule
{
    public Guid Id { get; init; }
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public Cabinet Cabinet { get; set; }
    public Subject Subject { get; set; }
    public Group Group { get; set; }
    public Teacher Teacher { get; set; }
}