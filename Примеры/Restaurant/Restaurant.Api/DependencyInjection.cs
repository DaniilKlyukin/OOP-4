using Microsoft.AspNetCore.Mvc.Infrastructure;
using Restaurant.Api.Common.Errors;
using Restaurant.Api.Common.Mapping;

namespace Restaurant.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();

        services.AddSingleton<ProblemDetailsFactory, RestaurantProblemDetailsFactory>();

        services.AddMappings();
        return services;
    }
}
