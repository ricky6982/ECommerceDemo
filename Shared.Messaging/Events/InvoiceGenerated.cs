namespace Shared.Messaging.Events;

/// <summary>
/// 
/// </summary>
/// <param name="OrderId"></param>
/// <param name="InvoiceNumber"></param>
/// <param name="CreatedAt"></param>
public record InvoiceGenerated(Guid OrderId, string InvoiceNumber, DateTime CreatedAt);
