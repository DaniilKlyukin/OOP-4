using MediatR;

namespace EduTrack.Application.Features.Cabinet.Commands;

// Command
public record CreateCabinetCommand(
    string Building,
    string Audience,
    string? Description) : IRequest<Guid>;
