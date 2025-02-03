namespace Domain.Models;

public class Note
{
    public const int MAX_TITLE_LENGTH = 256;

    public Note(Guid id, string title, string description, DateTime createdAt)
    {
        if (title.Length > MAX_TITLE_LENGTH)
            throw new ArgumentException($"Title mustn`t be bigger than {MAX_TITLE_LENGTH}");

        Id = id;
        Title = title;
        Description = description;
        CreatedAt = createdAt;
    }

    public Guid Id { get; }
    public string Title { get; }
    public string Description { get; }
    public DateTime CreatedAt { get; }
}