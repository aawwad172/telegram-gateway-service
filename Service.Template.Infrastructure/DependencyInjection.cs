using Microsoft.Extensions.DependencyInjection;
using Service.Template.Domain.Interfaces.Infrastructure;
using Service.Template.Infrastructure.Persistence;

namespace Service.Template.Infrastructure;

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
