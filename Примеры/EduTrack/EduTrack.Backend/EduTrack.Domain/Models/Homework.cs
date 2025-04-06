namespace EduTrack.Domain.Models;

public class Homework
{
    public Guid Id { get; init; }
    public string Content { get; set; }
    public DateTime Deadline { get; set; }
    public Subject Subject { get; set; }
    public Group Group { get; set; }
}