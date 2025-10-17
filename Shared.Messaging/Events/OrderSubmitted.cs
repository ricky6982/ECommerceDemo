namespace Shared.Messaging.Events;

public record OrderSubmitted(Guid OrderId, string CustomerEmail, decimal Amount);