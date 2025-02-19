using Restaurant.Domain.Entities;

namespace Restaurant.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}