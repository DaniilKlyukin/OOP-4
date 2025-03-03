using Restaurant.Domain.Common.Models;
using Restaurant.Domain.GuestAggregate.ValueObjects;

namespace Restaurant.Domain.GuestAggregate;

public sealed class Guest : AggregateRoot<GuestId, Guid>
{
    public Guest(GuestId id) : base(id)
    {
    }

    private Guest() { }
}