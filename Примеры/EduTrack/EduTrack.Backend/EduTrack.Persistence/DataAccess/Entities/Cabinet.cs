namespace EduTrack.Persistence.DataAccess.Entities;

public class Cabinet
{
    public Guid Id { get; set; }
    public string Building { get; set; } = null!;
    public string Audience { get; set; } = null!;
    public string? Description { get; set; }
}