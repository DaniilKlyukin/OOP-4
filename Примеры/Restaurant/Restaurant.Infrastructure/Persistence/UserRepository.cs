﻿using Restaurant.Application.Common.Interfaces.Persistence;
using Restaurant.Domain.UserAggregate;

namespace Restaurant.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();//Todo: перенести в БД

    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
        return _users.SingleOrDefault(x => x.Email == email);
    }
}
