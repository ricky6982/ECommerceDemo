namespace Shared.Messaging;

public record InvoiceGenerated(Guid OrderId, string InvoiceNumber, DateTime CreatedAt);
