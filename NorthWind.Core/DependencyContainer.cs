using NothWind.ConsoleApp.Services;
using NothWind.Entities.Interfaces;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddSingleton<IAppLogger, AppLogguer>();
        services.AddSingleton<IProductService, ProductService>();
        return services;
    }

}

