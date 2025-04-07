using EduTrack.Infrastructure.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace EduTrack.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddMappings();
        return services;
    }
}