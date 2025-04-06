namespace EduTrack.Domain.Models;

public class Group
{
    public Guid Id { get; init; }
    public string Name { get; set; }
    public string Specialization { get; set; }

    public IReadOnlyCollection<Student> Students => _students.AsReadOnly();
    
    private List<Student> _students = new();
}