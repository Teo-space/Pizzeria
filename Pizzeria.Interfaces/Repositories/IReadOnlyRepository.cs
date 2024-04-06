using Pizzeria.Domain.Deliveries;
using Pizzeria.Domain.Orders;
using Pizzeria.Domain.Products;
using Pizzeria.Domain.Shops;


namespace Pizzeria.Interfaces.Repositories;

public interface IReadOnlyRepository
{
    public IQueryable<DeliveryType> DeliveryTypes { get; }

    public IQueryable<Order> Orders { get; }
    public IQueryable<OrderPosition> OrderPositions { get; }

    public IQueryable<ProductType> ProductTypes { get; }
    public IQueryable<Product> Products { get; }

    public IQueryable<Shop> Shops { get; }


}
