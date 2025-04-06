using EduTrack.Infrastructure.Persistence;
using MediatR;

namespace EduTrack.Application.Features.Cabinet.Commands;

// Command
public record CreateCabinetCommand(
    string Building,
    string Audience,
    string? Description) : IRequest<Guid>;

// Handler
public class CreateCabinetCommandHandler : IRequestHandler<CreateCabinetCommand, Guid>
{
    private readonly EduTrackDbContext _context;

    public CreateCabinetCommandHandler(EduTrackDbContext context)
    {
        _context = context;
    }

    public async Task<Guid> Handle(
        CreateCabinetCommand request,
        CancellationToken cancellationToken)
    {
        var cabinet = new Domain.Cabinet
        {
            Id = Guid.NewGuid(),
            Building = request.Building,
            Audience = request.Audience,
            Description = request.Description
        };

        _context.Cabinets.Add(cabinet);
        await _context.SaveChangesAsync(cancellationToken);

        return cabinet.Id;
    }
}