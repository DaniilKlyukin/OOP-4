using Restaurant.Domain.Entities;

namespace Restaurant.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}
