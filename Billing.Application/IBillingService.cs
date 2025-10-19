namespace Billing.Application;

public interface IBillingService
{
    Task CreateBillingAsync(Guid orderId, string customerEmail, decimal amount);
}