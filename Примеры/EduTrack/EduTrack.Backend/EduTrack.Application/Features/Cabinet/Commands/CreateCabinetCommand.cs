using MediatR;

namespace EduTrack.Application.Features.Cabinet.Commands;

public record CreateCabinetCommand(
    string Building,
    string Audience,
    string? Description) : IRequest<Guid>;
