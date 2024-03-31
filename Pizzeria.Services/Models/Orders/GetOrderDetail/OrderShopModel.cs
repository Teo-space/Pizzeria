namespace Pizzeria.Services.Models.Orders.GetOrderDetail;

/// <summary>
/// Магазин отправления заказа
/// </summary>
public record OrderShopModel
{
    /// <summary>
    /// ID магазина
    /// </summary>
    public int ShopId { get; set; }

    /// <summary>
    /// наименование
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Адрес офиса
    /// </summary>
    public OrderShopAddressModel Address { get; set; }
}
