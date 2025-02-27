using ErrorOr;
using MediatR;
using Restaurant.Application.Authentication.Common;

namespace Restaurant.Application.Authentication.Queries.Login;
public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
