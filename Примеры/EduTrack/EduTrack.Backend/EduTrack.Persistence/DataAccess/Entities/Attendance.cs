using EduTrack.Domain.Enums;

namespace EduTrack.Persistence.DataAccess.Entities;

public class Attendance
{
    public Guid Id { get; set; }
    public AttendanceStatus Status { get; set; }
    public string? Comment { get; set; }

    public Guid LessonId { get; set; }
    public Lesson Lesson { get; set; } = null!;

    public Guid StudentId { get; set; }
    public Student Student { get; set; } = null!;
}