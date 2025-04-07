namespace EduTrack.Domain.Models;

public class Lesson
{
    public Guid Id { get; init; }
    public DateTime Date { get; set; }
    public string Topic { get; set; } = null!;
    public bool IsCanceled { get; set; }
    public Subject Subject { get; set; }
    public Teacher Teacher { get; set; }
    public Group Group { get; set; }
    public IReadOnlyCollection<Attendance> Attendance => _attendance.AsReadOnly();
    private List<Attendance> _attendance { get; set; } = new();
}