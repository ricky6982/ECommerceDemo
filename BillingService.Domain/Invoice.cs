namespace BillingService.Domain;

public class Invoice
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime CreatedAt { get; set; }
    public InvoiceStatus Status { get; set; }
}