using Pizzeria.Interfaces.Repositories;
using Pizzeria.Persistence.DbContexts;
using Pizzeria.Persistence.Repositories;

namespace Pizzeria.Persistence;


public static class DI
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddRepositories();
        services.AddDbContext<PizzeriaDbContext>(options => options.UseSqlServer(configuration.GetConnectionString(DbConnectionNames.Connection)));
    }

    private static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IRepository, Repository>();
        services.AddScoped<IReadOnlyRepository, ReadOnlyRepository>();
    }

}
