using MeetingScheduler.Application.Interfaces.Persistence;
using MeetingScheduler.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace MeetingScheduler.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IMeetingRepository, InMemoryMeetingRepository>();

        return services;
    }
}
