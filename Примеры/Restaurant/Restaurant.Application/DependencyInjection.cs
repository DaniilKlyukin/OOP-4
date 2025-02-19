using Microsoft.Extensions.DependencyInjection;
using Restaurant.Application.Common.Interfaces.Authentication;
using Restaurant.Application.Services.Authentication;

namespace Restaurant.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}
