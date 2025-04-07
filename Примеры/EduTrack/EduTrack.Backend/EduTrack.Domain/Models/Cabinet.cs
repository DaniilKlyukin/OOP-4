namespace EduTrack.Domain.Models;

public class Cabinet
{
    public Guid Id { get; init; }
    public string Building { get; set; } = null!;
    public string Audience { get; set; } = null!;
    public string? Description { get; set; }
}