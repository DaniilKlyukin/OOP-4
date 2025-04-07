using EduTrack.Api.Common.Mapping;

namespace EduTrack.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();

        services.AddMappings();
        return services;
    }
}
