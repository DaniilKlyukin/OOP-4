namespace Api.Contracts.CreateNote;

public record CreateNoteRequest(
    string Title,
    string Description);