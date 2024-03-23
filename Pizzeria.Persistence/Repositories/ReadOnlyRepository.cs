using Pizzeria.Domain.Deliveries;
using Pizzeria.Domain.Orders;
using Pizzeria.Domain.Products;
using Pizzeria.Interfaces.Repositories;
using Pizzeria.Persistence.DbContexts;

namespace Pizzeria.Persistence.Repositories;

internal class ReadOnlyRepository(PizzeriaDbContext dbContext) : IReadOnlyRepository
{
    public IQueryable<DeliveryType> DeliveryTypes => dbContext.DeliveryTypes.AsNoTracking();

    public IQueryable<Order> Orders => dbContext.Orders.AsNoTracking();
    public IQueryable<OrderPosition> OrderPositions => dbContext.OrderPositions.AsNoTracking();

    public IQueryable<ProductType> ProductTypes => dbContext.ProductTypes.AsNoTracking();
    public IQueryable<Product> Products => dbContext.Products.AsNoTracking();
    public IQueryable<ProductVariant> ProductVariants => dbContext.ProductVariants.AsNoTracking();

}


