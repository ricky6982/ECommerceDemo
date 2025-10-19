namespace Billing.Application;

public class BillingService : IBillingService
{
    public Task CreateBillingAsync(Guid messageOrderId, string customerEmail, decimal amount)
    {
        Console.WriteLine($"Create Billing for Order {messageOrderId} for user {customerEmail} with amount {amount}.");
        
        // random secods between 1 and 10
        var random = new Random();
        var seconds = random.Next(1, 10) * 1000;
        
        Thread.Sleep(seconds);
        Console.WriteLine($"Time elapsed: {seconds} seconds.");
        Console.WriteLine($"Billing for Order {messageOrderId} has been created.");
        
        return Task.CompletedTask;
    }
}