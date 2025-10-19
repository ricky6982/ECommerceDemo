using MassTransit;

namespace Shared.Infrastructure.MassTransit;

public static class MassTransitExtensions
{
    public static void AddDefaultRabbitMq(this IBusRegistrationConfigurator x)
    {
        x.SetKebabCaseEndpointNameFormatter();

        x.UsingRabbitMq((context, cfg) =>
        {
            cfg.Host("localhost", 5672,"/", h =>
            {
                h.Username("guest");
                h.Password("guest");
            });

            cfg.ConfigureEndpoints(context);
        });
    }
}