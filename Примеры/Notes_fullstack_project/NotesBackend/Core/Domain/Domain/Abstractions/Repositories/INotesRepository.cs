using Domain.Models;

namespace Domain.Abstractions.Repositories;

public interface INotesRepository
{
    Task<List<Note>> GetAll();
    Task<Note?> GetById(Guid id);
    Task<Note> Create(Note note);
    Task<Note> Update(Note note);
    Task<Guid> Delete(Guid id);
}