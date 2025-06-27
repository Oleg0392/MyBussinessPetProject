using OrdersDomain.Abstractions;
using OrdersDomain.Models;

namespace OrdersDomain.Events;

public record OrderCreatedEvent(Order order) : IDomainEvent;
