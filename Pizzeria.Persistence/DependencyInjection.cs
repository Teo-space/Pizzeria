using Pizzeria.Interfaces.Repositories;
using Pizzeria.Persistence.DbContexts;
using Pizzeria.Persistence.Repositories;

namespace Pizzeria.Persistence;


public static class PersistenceDependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddRepositories();

        services.AddDbContext<PizzeriaDbContext>(options => options
        .UseSqlServer(configuration.GetConnectionString(DbConnectionNames.Connection)));

        return services;
    }

    public static IServiceCollection AddTestInfrastructure(this IServiceCollection services)
    {
        services.AddRepositories();

        services.AddDbContext<PizzeriaDbContext>(options => options
        .UseSqlite($"DataSource=file:DbContext_{Guid.NewGuid()}?mode=memory&cache=shared"));

        return services;
    }

    private static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IRepository, Repository>();
        services.AddScoped<IReadOnlyRepository, ReadOnlyRepository>();
    }

}
