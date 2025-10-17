using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Shared.Infrastructure.MassTransit;

namespace Billing.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddMassTransit(x =>
        {
            x.AddConsumers(typeof(DependencyInjection).Assembly);
            x.AddDefaultRabbitMq();
        });

        return services;
    }
}