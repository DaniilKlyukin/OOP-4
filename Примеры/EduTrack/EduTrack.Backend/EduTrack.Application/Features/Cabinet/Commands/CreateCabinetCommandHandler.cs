using CabinetModel = EduTrack.Domain.Models.Cabinet;
using CabinetEntity = EduTrack.Persistence.DataAccess.Entities.Cabinet;
using MediatR;
using EduTrack.Persistence;
using MapsterMapper;

namespace EduTrack.Application.Features.Cabinet.Commands;

public class CreateCabinetCommandHandler : IRequestHandler<CreateCabinetCommand, Guid>
{
    private readonly EduTrackDbContext _context;
    private readonly IMapper _mapper;

    public CreateCabinetCommandHandler(EduTrackDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(
        CreateCabinetCommand command,
        CancellationToken cancellationToken)
    {
        var cabinet = _mapper.Map<CabinetModel>(command);
        var cabinetEntity = _mapper.Map<CabinetEntity>(cabinet);

        _context.Cabinets.Add(cabinetEntity);
        await _context.SaveChangesAsync(cancellationToken);

        return cabinet.Id;
    }
}