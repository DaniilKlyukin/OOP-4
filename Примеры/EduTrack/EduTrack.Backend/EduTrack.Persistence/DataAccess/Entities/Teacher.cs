using EduTrack.Domain.Enums;

namespace EduTrack.Persistence.DataAccess.Entities;


public class Teacher
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? Patronymic { get; set; }
    public Gender Gender { get; set; }
    public DateTime Birthday { get; set; }
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public Guid DepartmentId { get; set; }
    public Department Department { get; set; }
}