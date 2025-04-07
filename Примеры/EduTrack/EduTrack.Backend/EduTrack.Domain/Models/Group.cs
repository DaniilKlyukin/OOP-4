namespace EduTrack.Domain.Models;

public class Group
{
    public Guid Id { get; init; }
    public string Name { get; set; } = null!;
    public string Specialization { get; set; } = null!;

    public IReadOnlyCollection<Student> Students => _students.AsReadOnly();
    
    private List<Student> _students = new();
}