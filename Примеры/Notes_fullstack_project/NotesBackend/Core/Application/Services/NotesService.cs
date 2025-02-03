using Domain.Abstractions.Repositories;
using Domain.Abstractions.Services;
using Domain.Models;

namespace Application.Services;

public class NotesService : INotesService
{
    private readonly INotesRepository _repository;

    public NotesService(INotesRepository repository)
    {
        _repository = repository;
    }

    public async Task<Note> CreateNote(string title, string description)
    {
        var note = new Note(Guid.NewGuid(), title, description, DateTime.UtcNow);

        await _repository.Create(note);

        return note;
    }

    public async Task<Guid> DeleteNote(Guid id)
    {
        return await _repository.Delete(id);
    }

    public async Task<Note> UpdateNote(Guid id, string? title, string? description)
    {
        var note = await _repository.GetById(id);

        if (note == null)
            throw new Exception("Note not found");

        var updated = new Note(id, title ?? note.Title, description ?? note.Description, DateTime.UtcNow);

        return await _repository.Update(updated);
    }
}
