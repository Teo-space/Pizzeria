using Pizzeria.Interfaces.Repositories;
using Pizzeria.Persistence.DbContexts;

namespace Pizzeria.Persistence.Repositories;


internal class UnitOfWork(PizzeriaDbContext dbContext) : IUnitOfWork
{
    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var domainEvents = dbContext.ChangeTracker
            .Entries<Entity>()
            .Select(e => e.Entity)
            .Where(entity => entity.DomainEvents.Any())
            .SelectMany(entity => entity.DomainEvents)
            .ToList();

        foreach (var domainEvent in domainEvents)
        {
            //Publish
        }


        return await dbContext.SaveChangesAsync(cancellationToken);
    }


}
