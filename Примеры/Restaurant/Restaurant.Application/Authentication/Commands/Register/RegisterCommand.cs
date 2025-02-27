using ErrorOr;
using MediatR;
using Restaurant.Application.Authentication.Common;

namespace Restaurant.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;