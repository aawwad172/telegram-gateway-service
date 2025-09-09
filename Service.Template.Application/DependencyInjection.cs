using Microsoft.Extensions.DependencyInjection;
using Service.Template.Application.Utilities;

namespace Service.Template.Application;

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
