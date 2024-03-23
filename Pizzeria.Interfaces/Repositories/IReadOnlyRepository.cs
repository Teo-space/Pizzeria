using Pizzeria.Domain.Deliveries;
using Pizzeria.Domain.Orders;
using Pizzeria.Domain.Products;

namespace Pizzeria.Interfaces.Repositories;

public interface IReadOnlyRepository
{
    public IQueryable<DeliveryType> DeliveryTypes { get; }

    public IQueryable<Order> Orders { get; }
    public IQueryable<OrderPosition> OrderPositions { get; }

    public IQueryable<ProductType> ProductTypes { get; }
    public IQueryable<Product> Products { get; }
    public IQueryable<ProductVariant> ProductVariants { get; }

}
