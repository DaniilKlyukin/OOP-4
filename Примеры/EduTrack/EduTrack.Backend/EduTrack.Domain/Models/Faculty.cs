namespace EduTrack.Domain.Models;

public class Faculty
{
    public Guid Id { get; init; }
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public IReadOnlyCollection<Department> Departments => _departments.AsReadOnly();
    
    private List<Department> _departments = new();
}
