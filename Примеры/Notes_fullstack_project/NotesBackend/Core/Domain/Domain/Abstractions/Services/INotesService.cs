using Domain.Models;

namespace Domain.Abstractions.Services;

public interface INotesService
{
    public Task<Note> CreateNote(string title, string description);

    public Task<Guid> DeleteNote(Guid id);

    public Task<Note> UpdateNote(Guid id, string? title, string? description);
}
