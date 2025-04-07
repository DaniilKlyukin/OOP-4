using CabinetModel = EduTrack.Domain.Models.Cabinet;
using EduTrack.Infrastructure.Persistence;
using CabinetEntity = EduTrack.Infrastructure.Persistence.DataAccess.Entities.Cabinet;
using MediatR;

namespace EduTrack.Application.Features.Cabinet.Commands;

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
        var cabinet = new CabinetModel
        {
            Id = Guid.NewGuid(),
            Building = request.Building,
            Audience = request.Audience,
            Description = request.Description
        };

        var cabinetEntity = new CabinetEntity 
        {
            Id = cabinet.Id,
            Building = cabinet.Building,
            Audience = cabinet.Audience,
            Description = cabinet.Description
        };

        _context.Cabinets.Add(cabinetEntity);
        await _context.SaveChangesAsync(cancellationToken);

        return cabinet.Id;
    }
}