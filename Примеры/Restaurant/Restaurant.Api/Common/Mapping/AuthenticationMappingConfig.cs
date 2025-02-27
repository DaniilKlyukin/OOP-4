using Mapster;
using Restaurant.Application.Authentication.Commands.Register;
using Restaurant.Application.Authentication.Common;
using Restaurant.Application.Authentication.Queries.Login;
using Restaurant.Contracts.Authentication;

namespace Restaurant.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
              .Map(dest => dest.Token, src => src.Token)
              .Map(dest => dest, src => src.User);
    }
}