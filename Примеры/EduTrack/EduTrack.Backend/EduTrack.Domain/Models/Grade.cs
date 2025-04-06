namespace EduTrack.Domain.Models;

public class Grade
{
    public Guid Id { get; init; }
    public DateTime Date { get; set; }
    public int Value { get; set; }
    public string? Comment { get; set; }
    public Subject Subject { get; set; }
    public Student Student { get; set; }
}