using EduTrack.Domain.Enums;

namespace EduTrack.Domain.Models;

public class Teacher
{
    public Guid Id { get; init; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? Patronymic { get; set; } = null!;
    public Gender Gender { get; set; }
    public int Age { get; set; }
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public Department Department { get; set; }
}