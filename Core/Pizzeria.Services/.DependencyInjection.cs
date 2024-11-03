using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pizzeria.Interfaces.Services;

namespace Pizzeria.Services;

public static class ServicesDependencyInjection
{
    public static IServiceCollection AddTestServices(this IServiceCollection services)
    {
        services.AddScoped<IOrdersService, OrdersService>();
        services.AddScoped<ICatalogService, CatalogService>();
        services.AddScoped<IDeliveriesService, DeliveriesService>();
        services.AddScoped<IPaymentsService, PaymentsService>();
        services.AddScoped<IProductsService, ProductsService>();
        services.AddScoped<IShopsService, ShopsService>();




        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IOrdersService, OrdersService>();
        services.AddScoped<ICatalogService, CatalogService>();
        services.AddScoped<IDeliveriesService, DeliveriesService>();
        services.AddScoped<IPaymentsService, PaymentsService>();
        services.AddScoped<IProductsService, ProductsService>();
        services.AddScoped<IShopsService, ShopsService>();



        return services;
    }



}
