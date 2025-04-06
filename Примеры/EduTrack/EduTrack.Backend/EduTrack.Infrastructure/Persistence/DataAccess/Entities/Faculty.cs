namespace EduTrack.Infrastructure.Persistence.DataAccess.Entities;

public class Faculty
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public List<Department> Departments { get; set; } = new();
}