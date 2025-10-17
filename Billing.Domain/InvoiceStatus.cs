namespace Billing.Domain;

public enum InvoiceStatus
{
    Pending = 0,
    Paid = 1,
    Overdue = 2,
    Refunded = 3,
}