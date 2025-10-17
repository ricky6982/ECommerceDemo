using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Shared.Infrastructure.MassTransit;

namespace OrderService.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // Configuración de MassTransit para este microservicio
        services.AddMassTransit(x =>
        {
            x.AddConsumers(typeof(DependencyInjection).Assembly);
            x.AddDefaultRabbitMq(); // usa el helper compartido
        });

        return services;
    }
}