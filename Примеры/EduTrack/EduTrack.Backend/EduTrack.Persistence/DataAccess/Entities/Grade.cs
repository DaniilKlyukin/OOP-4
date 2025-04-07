namespace EduTrack.Persistence.DataAccess.Entities;

public class Grade
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public int Value { get; set; }
    public string? Comment { get; set; }

    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; }

    public Guid StudentId { get; set; }
    public Student Student { get; set; }
}