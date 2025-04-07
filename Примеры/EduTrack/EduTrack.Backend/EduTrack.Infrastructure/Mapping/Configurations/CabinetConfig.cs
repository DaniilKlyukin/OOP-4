using CabinetModel = EduTrack.Domain.Models.Cabinet;
using CabinetEntitу = EduTrack.Persistence.DataAccess.Entities.Cabinet;
using Mapster;
using EduTrack.Application.Features.Cabinet.Commands;
using EduTrack.Contracts.Cabinet.Create;

namespace EduTrack.Infrastructure.Mapping.Configurations;

public class CabinetMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreateCabinetRequest, CreateCabinetCommand>()
            .Map(dest => dest.Building, src => src.Building)
            .Map(dest => dest.Audience, src => src.Audience)
            .Map(dest => dest.Description, src => src.Description);

        config.NewConfig<CreateCabinetCommand, CabinetEntitу>()
            .Map(dest => dest.Id, _ => Guid.NewGuid())
            .Map(dest => dest.Building, src => src.Building.Trim())
            .Map(dest => dest.Audience, src => src.Audience.Trim())
            .Map(dest => dest.Description, src => src.Description);

        config.NewConfig<CabinetEntitу, CabinetModel>()
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Building, src => src.Building)
            .Map(dest => dest.Audience, src => src.Audience)
            .Map(dest => dest.Description, src => src.Description);
    }
}
