using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pizzeria.Services.Interfaces.Services;

namespace Pizzeria.Services;

public static class ServicesDependencyInjection
{
    public static IServiceCollection AddTestServices(this IServiceCollection services)
    {
        services.AddScoped<IOrdersService, OrdersService>();



        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IOrdersService, OrdersService>();



        return services;
    }



}
