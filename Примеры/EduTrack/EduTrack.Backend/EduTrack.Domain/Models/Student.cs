namespace EduTrack.Domain.Models;

public class Student
{
    public Guid Id { get; init; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? Patronymic { get; set; }
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public Group Group { get; set; }
}