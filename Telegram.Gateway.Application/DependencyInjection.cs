using Microsoft.Extensions.DependencyInjection;
using Telegram.Gateway.Application.Utilities;

namespace Telegram.Gateway.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Register application services here
        // Example: services.AddTransient<IMyService, MyService>();

        MapsterConfigurations.RegisterMappings();

        return services;
    }
}
