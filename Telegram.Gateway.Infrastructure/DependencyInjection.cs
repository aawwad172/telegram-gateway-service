using Microsoft.Extensions.DependencyInjection;
using Telegram.Gateway.Domain.Interfaces.Infrastructure;
using Telegram.Gateway.Infrastructure.Persistence;

namespace Telegram.Gateway.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        // Register infrastructure services here
        // Example: services.AddTransient<IMyInfrastructureService, MyInfrastructureService>();

        services.AddSingleton<IDbConnectionFactory, DbConnectionFactory>();

        return services;
    }
}
