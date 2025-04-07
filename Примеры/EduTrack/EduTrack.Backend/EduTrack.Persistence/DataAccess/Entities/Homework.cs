namespace EduTrack.Persistence.DataAccess.Entities;

public class Homework
{
    public Guid Id { get; set; }
    public string Content { get; set; } = null!;
    public DateTime Deadline { get; set; }

    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; }

    public Guid GroupId { get; set; }
    public Group Group { get; set; }
}
