using Domain.Models;

namespace Domain.Abstractions.Services;

public interface ILargestNoteService
{
    Task<Note?> GetLargestNote();
}