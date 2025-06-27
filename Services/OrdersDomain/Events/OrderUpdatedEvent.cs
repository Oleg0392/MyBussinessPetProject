using OrdersDomain.Abstractions;
using OrdersDomain.Models;

namespace OrdersDomain.Events;

public record OrderUpdatedEvent(Order order) : IDomainEvent;
