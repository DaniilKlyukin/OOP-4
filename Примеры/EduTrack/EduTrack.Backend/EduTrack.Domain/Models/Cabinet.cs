namespace EduTrack.Domain.Models;

public class Cabinet
{
    public Guid Id { get; init; }
    public string Building { get; set; }
    public string Audience { get; set; }
    public string? Description { get; set; }
}