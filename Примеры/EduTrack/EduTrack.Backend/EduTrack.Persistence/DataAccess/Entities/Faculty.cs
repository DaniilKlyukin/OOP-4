namespace EduTrack.Persistence.DataAccess.Entities;

public class Faculty
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public List<Department> Departments { get; set; } = new();
}