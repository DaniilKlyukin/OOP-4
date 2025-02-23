﻿
using ErrorOr;
using Restaurant.Application.Services.Authentication;

namespace Restaurant.Application.Common.Interfaces.Authentication;

public interface IAuthenticationService
{
    ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password);

    ErrorOr<AuthenticationResult> Login(string email, string password);
}