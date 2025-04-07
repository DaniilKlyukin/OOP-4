using EduTrack.Domain.Enums;

namespace EduTrack.Persistence.DataAccess.Entities;

public class Exam
{
    public Guid Id { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public ExamType Type { get; set; }

    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; }

    public Guid GroupId { get; set; }
    public Group Group { get; set; }
}