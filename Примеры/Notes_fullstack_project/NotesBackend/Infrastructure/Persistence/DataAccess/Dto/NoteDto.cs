namespace Persistence.DataAccess.Dto;

public record class NoteDto(Guid Id, string Title, string Description, DateTime CreatedAt);
