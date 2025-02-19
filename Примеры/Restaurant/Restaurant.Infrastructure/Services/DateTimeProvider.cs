using Restaurant.Application.Common.Interfaces.Services;

namespace Restaurant.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}