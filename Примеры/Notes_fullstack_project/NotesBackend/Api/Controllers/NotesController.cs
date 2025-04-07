using Api.Contracts.CreateNote;
using Api.Contracts.DeleteNote;
using Api.Contracts.GetLargestNote;
using Api.Contracts.GetNotes;
using Api.Contracts.UpdateNote;
using Domain.Abstractions.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Linq.Expressions;
using Note = Domain.Models.Note;
using NoteEntity = Persistence.DataAccess.Entities.Note;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class NotesController : ControllerBase
{
    private readonly INotesService _noteService;
    private readonly ILargestNoteService _largestNoteService;
    private readonly NotesDbContext _notesDbContext;

    public NotesController(
        INotesService noteService,
        ILargestNoteService largestNoteService,
        NotesDbContext notesDbContext)
    {

        _noteService = noteService;
        _largestNoteService = largestNoteService;
        _notesDbContext = notesDbContext;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreateNoteRequest request)
    {
        var note = await _noteService.CreateNote(request.Title, request.Description);

        return Ok(new CreateNoteResponse(note));
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetNotesRequest request)
    {
        var notesQuery = _notesDbContext.Notes
            .AsNoTracking();

        if (request.Search != null)
        {
            var lower = request.Search.ToLower();

            notesQuery = notesQuery
                .Where(n => n.Title.ToLower().Contains(lower));
        }

        Expression<Func<NoteEntity, object>> selectorKey =
            request.SortItem?.ToLower() switch
            {
                "date" => note => note.CreatedAt,
                "title" => note => note.Title,
                _ => note => note.Id
            };

        notesQuery = request.SortOrder == "desc"
            ? notesQuery.OrderByDescending(selectorKey)
            : notesQuery.OrderBy(selectorKey);

        var notes = await notesQuery
            .Select(n => new Note(n.Id, n.Title, n.Description, n.CreatedAt))
            .ToListAsync();

        return Ok(new GetNotesResponse(notes));
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete([FromBody] DeleteNoteRequest request)
    {
        var note = await _noteService.DeleteNote(request.Id);

        return Ok(new DeleteNoteResponse(note));
    }

    [HttpPatch("Update")]
    public async Task<IActionResult> Update([FromBody] UpdateNoteRequest request)
    {
        var note = await _noteService.UpdateNote(request.Id, request.Title, request.Description);

        return Ok(new UpdateNoteResponse(note));
    }

    [HttpGet("LargestNote")]
    public async Task<IActionResult> GetLargestNote()
    {
        var largestNote = await _largestNoteService.GetLargestNote();

        if (largestNote == null)
        {
            return Ok("No notes");
        }

        return Ok(new GetLargestNoteResponse(largestNote));
    }
}