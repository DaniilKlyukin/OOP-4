using EduTrack.Domain.Enums;

namespace EduTrack.Domain.Models;

public class Attendance
{
    public Guid Id { get; init; }
    public AttendanceStatus Status { get; set; }
    public string? Comment { get; set; }
    public Lesson Lesson { get; set; }
    public Student Student { get; set; }
}