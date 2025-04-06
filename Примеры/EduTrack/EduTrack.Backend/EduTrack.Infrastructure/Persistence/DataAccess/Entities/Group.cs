namespace EduTrack.Infrastructure.Persistence.DataAccess.Entities;

public class Group
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }

    public List<Student> Students { get; set; } = new();
}