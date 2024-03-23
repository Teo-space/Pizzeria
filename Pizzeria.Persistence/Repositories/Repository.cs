using Pizzeria.Domain.Deliveries;
using Pizzeria.Domain.Orders;
using Pizzeria.Domain.Products;
using Pizzeria.Interfaces.Repositories;
using Pizzeria.Persistence.DbContexts;

namespace Pizzeria.Persistence.Repositories;

internal class Repository(PizzeriaDbContext dbContext) : IRepository
{

    public DbSet<DeliveryType> DeliveryTypes => dbContext.DeliveryTypes;

    public DbSet<Order> Orders => dbContext.Orders;
    public DbSet<OrderPosition> OrderPositions => dbContext.OrderPositions;

    public DbSet<ProductType> ProductTypes => dbContext.ProductTypes;
    public DbSet<Product> Products => dbContext.Products;
    public DbSet<ProductVariant> ProductVariants => dbContext.ProductVariants;

}


