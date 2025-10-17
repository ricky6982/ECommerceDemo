namespace Shared.Messaging.Events;

public record InvoiceGenerated(Guid OrderId, string InvoiceNumber, DateTime CreatedAt);
