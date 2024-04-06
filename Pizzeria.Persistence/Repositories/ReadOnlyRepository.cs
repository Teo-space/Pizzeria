using Pizzeria.Interfaces.Repositories;
using Pizzeria.Persistence.DbContexts;

namespace Pizzeria.Persistence.Repositories;

internal class ReadOnlyRepository(PizzeriaDbContext dbContext) : IReadOnlyRepository
{
    public IQueryable<DeliveryStatus> DeliveryStatuses => dbContext.DeliveryStatuses.AsNoTracking();
    public IQueryable<DeliveryType> DeliveryTypes => dbContext.DeliveryTypes.AsNoTracking();

    public IQueryable<Order> Orders => dbContext.Orders.AsNoTracking();
    public IQueryable<OrderPosition> OrderPositions => dbContext.OrderPositions.AsNoTracking();

    public IQueryable<PaymentType> PaymentTypes => dbContext.PaymentTypes.AsNoTracking();

    public IQueryable<ProductType> ProductTypes => dbContext.ProductTypes.AsNoTracking();
    public IQueryable<Product> Products => dbContext.Products.AsNoTracking();

    public IQueryable<Shop> Shops => dbContext.Shops.AsNoTracking();

}


