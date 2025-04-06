namespace EduTrack.Infrastructure.Persistence.DataAccess.Entities;

public class Department
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public Guid FacultyId { get; set; }
    public Faculty Faculty { get; set; } = null!;

    public Guid CabinetId { get; set; }
    public Cabinet Cabinet { get; set; } = null!;
}
