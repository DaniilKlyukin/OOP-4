namespace EduTrack.Domain.Models;

public class Subject
{
    public Guid Id { get; init; }
    public string Name { get; set; }
    public string Description { get; set; }
}