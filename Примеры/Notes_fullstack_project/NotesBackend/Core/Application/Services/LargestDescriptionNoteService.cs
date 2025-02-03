using Domain.Abstractions.Repositories;
using Domain.Abstractions.Services;
using Domain.Models;

namespace Application.Services;

public class LargestDescriptionNoteService : ILargestNoteService
{
    private readonly INotesRepository _notesRepository;

    public LargestDescriptionNoteService(INotesRepository notesRepository)
    {
        _notesRepository = notesRepository;
    }

    public async Task<Note?> GetLargestNote()
    {
        var notes = await _notesRepository.GetAll();

        return notes.MaxBy(n => n.Description.Length);
    }
}
