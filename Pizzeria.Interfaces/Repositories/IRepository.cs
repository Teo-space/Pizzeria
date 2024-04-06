using Microsoft.EntityFrameworkCore;
using Pizzeria.Domain.Deliveries;
using Pizzeria.Domain.Orders;
using Pizzeria.Domain.Products;
using Pizzeria.Domain.Shops;

namespace Pizzeria.Interfaces.Repositories;

public interface IRepository
{
    public DbSet<DeliveryType> DeliveryTypes { get; }

    public DbSet<Order> Orders { get; }
    public DbSet<OrderPosition> OrderPositions { get; }

    public DbSet<ProductType> ProductTypes { get; }
    public DbSet<Product> Products { get; }

    public DbSet<Shop> Shops { get; }


}