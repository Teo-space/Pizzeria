using Pizzeria.Interfaces.Repositories;
using Pizzeria.Persistence.DbContexts;

namespace Pizzeria.Persistence.Repositories;

internal class Repository(PizzeriaDbContext dbContext) : IRepository
{
    public DbSet<DeliveryStatus> DeliveryStatuses => dbContext.DeliveryStatuses;
    public DbSet<DeliveryType> DeliveryTypes => dbContext.DeliveryTypes;

    public DbSet<Order> Orders => dbContext.Orders;
    public DbSet<OrderPosition> OrderPositions => dbContext.OrderPositions;

    public DbSet<PaymentType> PaymentTypes => dbContext.PaymentTypes;

    public DbSet<ProductType> ProductTypes => dbContext.ProductTypes;
    public DbSet<Product> Products => dbContext.Products;

    public DbSet<Shop> Shops => dbContext.Shops;


}


