namespace Pizzeria.Rest.Models.Catalog;

using Pizzeria.Rest.Models.Deliveries;
using Pizzeria.Rest.Models.Payments;
using Pizzeria.Rest.Models.Products;
using Pizzeria.Rest.Models.Shops;

/// <summary>
/// Каталог магазина
/// </summary>
public record CatalogModel
{
    /// <summary>
    /// Список доступных типов доставки
    /// </summary>
    public IReadOnlyCollection<DeliveryTypeModel> DeliveryTypes { get; set; } = new List<DeliveryTypeModel>();

    /// <summary>
    /// Список доступных типов оплаты
    /// </summary>
    public IReadOnlyCollection<PaymentTypeModel> PaymentTypes { get; set; } = new List<PaymentTypeModel>();

    /// <summary>
    /// Список доступных магазинов из которых возможен заказ
    /// </summary>
    public IReadOnlyCollection<ShopModel> Shops { get; set; } = new List<ShopModel>();

    /// <summary>
    /// Список доступных типов товаров с товарами
    /// </summary>
    public IReadOnlyCollection<ProductTypeModel> ProductTypes { get; set; } = new List<ProductTypeModel>();

}
