using Domain.Models;

namespace Api.Contracts.GetNotes;

public record GetNotesResponse(List<Note> Notes);