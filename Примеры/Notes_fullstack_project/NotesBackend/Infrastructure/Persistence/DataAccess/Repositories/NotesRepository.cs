using Domain.Abstractions.Repositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DataAccess.Repositories;

public class NotesRepository : INotesRepository
{
    private readonly NotesDbContext _context;

    public NotesRepository(NotesDbContext context)
    {
        _context = context;
    }

    public async Task<Note> Create(Note note)
    {
        var noteEntity = new Entities.Note
        {
            Id = note.Id,
            Title = note.Title,
            Description = note.Description,
            CreatedAt = note.CreatedAt,
        };

        await _context.AddAsync(noteEntity);
        await _context.SaveChangesAsync();

        return note;
    }

    public async Task<List<Note>> GetAll()
    {
        var notesEntities = await _context.Notes
            .AsNoTracking()
            .ToListAsync();

        var notes = notesEntities
            .Select(n => new Note(n.Id, n.Title, n.Description, n.CreatedAt))
            .ToList();

        return notes;
    }

    public async Task<Note?> GetById(Guid id)
    {
        var noteEntity = await _context.Notes
            .AsNoTracking()
            .SingleOrDefaultAsync(n => n.Id == id);

        if (noteEntity == null)
            return null;

        return new Note(
            noteEntity.Id, 
            noteEntity.Title,
            noteEntity.Description, 
            noteEntity.CreatedAt);
    }

    public async Task<Note> Update(Note note)
    {
        await _context.Notes
            .Where(n => n.Id == note.Id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(n => n.Title, n => note.Title)
                .SetProperty(n => n.Description, n => note.Description)
                .SetProperty(n => n.CreatedAt, n => note.CreatedAt));

        return note;
    }

    public async Task<Guid> Delete(Guid id)
    {
        await _context.Notes
            .Where(n => n.Id == id)
            .ExecuteDeleteAsync();

        return id;
    }
}