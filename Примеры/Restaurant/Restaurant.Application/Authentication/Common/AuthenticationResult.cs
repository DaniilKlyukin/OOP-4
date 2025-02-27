using Restaurant.Domain.Entities;

namespace Restaurant.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);