using Restaurant.Domain.UserAggregate;

namespace Restaurant.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);