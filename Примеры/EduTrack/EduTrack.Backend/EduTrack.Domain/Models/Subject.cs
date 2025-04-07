namespace EduTrack.Domain.Models;

public class Subject
{
    public Guid Id { get; init; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
}