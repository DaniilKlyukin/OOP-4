using Restaurant.Domain.Common.Models;

namespace Restaurant.Domain.MenuAggregate.Events;

public record MenuCreated(Menu Menu) : IDomainEvent;