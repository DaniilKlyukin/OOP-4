namespace EduTrack.Domain.Models;

public class Department
{
    public Guid Id { get; init; }
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public Faculty Faculty { get; set; }
    public Cabinet Cabinet { get; set; }
}
