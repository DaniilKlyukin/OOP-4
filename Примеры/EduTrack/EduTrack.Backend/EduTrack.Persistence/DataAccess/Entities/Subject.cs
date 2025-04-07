namespace EduTrack.Persistence.DataAccess.Entities;

public class Subject
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
}