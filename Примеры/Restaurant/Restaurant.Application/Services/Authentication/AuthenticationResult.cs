using Restaurant.Domain.Entities;

namespace Restaurant.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token);