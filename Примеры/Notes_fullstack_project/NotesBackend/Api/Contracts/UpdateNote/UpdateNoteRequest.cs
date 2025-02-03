namespace Api.Contracts.UpdateNote;

public record UpdateNoteRequest(
    Guid Id,
    string? Title,
    string? Description);