using Pizzeria.Models.Deliveries;
using Pizzeria.Models.Payments;
using Pizzeria.Models.Products;
using Pizzeria.Models.Shops;

namespace Pizzeria.Models.Catalog;

/// <summary>
/// Каталог магазина
/// </summary>
public sealed record CatalogModel : OutputModel
{
    /// <summary>
    /// Список доступных типов доставки
    /// </summary>
    public IReadOnlyCollection<DeliveryTypeModel> DeliveryTypes { get; init; } = Array.Empty<DeliveryTypeModel>();

    /// <summary>
    /// Список доступных типов оплаты
    /// </summary>
    public IReadOnlyCollection<PaymentTypeModel> PaymentTypes { get; init; } = Array.Empty<PaymentTypeModel>();

    /// <summary>
    /// Список доступных магазинов из которых возможен заказ
    /// </summary>
    public IReadOnlyCollection<ShopModel> Shops { get; init; } = Array.Empty<ShopModel>();

    /// <summary>
    /// Список доступных типов товаров с товарами
    /// </summary>
    public IReadOnlyCollection<ProductTypeModel> ProductTypes { get; init; } = Array.Empty<ProductTypeModel>();

}