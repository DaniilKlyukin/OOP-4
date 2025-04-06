namespace EduTrack.Domain.Models;

public class Student
{
    public Guid Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Patronymic { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Group Group { get; set; }
}