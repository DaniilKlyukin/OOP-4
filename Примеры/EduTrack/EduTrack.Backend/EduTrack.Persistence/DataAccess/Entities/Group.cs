namespace EduTrack.Persistence.DataAccess.Entities;

public class Group
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Specialization { get; set; } = null!;

    public List<Student> Students { get; set; } = new();
}