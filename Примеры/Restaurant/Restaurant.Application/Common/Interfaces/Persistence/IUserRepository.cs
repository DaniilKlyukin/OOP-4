using Restaurant.Domain.UserAggregate;

namespace Restaurant.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}
