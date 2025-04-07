namespace EduTrack.Persistence.DataAccess.Entities;

public class Lesson
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string Topic { get; set; } = null!;
    public bool IsCanceled { get; set; }

    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; }

    public Guid TeacherId { get; set; }
    public Teacher Teacher { get; set; }

    public Guid GroupId { get; set; }
    public Group Group { get; set; }

    public List<Attendance> Attendances { get; set; } = new();
}