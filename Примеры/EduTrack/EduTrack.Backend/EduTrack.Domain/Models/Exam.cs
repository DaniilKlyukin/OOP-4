using EduTrack.Domain.Enums;

namespace EduTrack.Domain.Models;

public class Exam
{
    public Guid Id { get; init; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public ExamType Type { get; set; }
    public Subject Subject { get; set; }
    public Group Group { get; set; }
}