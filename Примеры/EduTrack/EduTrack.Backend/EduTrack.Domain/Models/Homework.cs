namespace EduTrack.Domain.Models;

public class Homework
{
    public Guid Id { get; init; }
    public string Content { get; set; } = null!;
    public DateTime Deadline { get; set; }
    public Subject Subject { get; set; }
    public Group Group { get; set; }
}