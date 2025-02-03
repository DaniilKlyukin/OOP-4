namespace Api.Contracts.GetNotes;

public record GetNotesRequest(
    string? Search,
    string? SortItem,
    string? SortOrder);