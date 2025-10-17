namespace Shared.Messaging;

public record OrderSubmitted(Guid OrderId, string CustomerEmail, decimal Amount);