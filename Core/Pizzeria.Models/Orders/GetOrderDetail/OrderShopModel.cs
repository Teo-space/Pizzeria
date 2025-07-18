namespace Pizzeria.Models.Orders.GetOrderDetail;

/// <summary>
/// Магазин отправления заказа
/// </summary>
public sealed record OrderShopModel : OutputModel
{
    /// <summary>
    /// ID магазина
    /// </summary>
    public int ShopId { get; init; }

    /// <summary>
    /// наименование
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Адрес офиса
    /// </summary>
    public OrderShopAddressModel Address { get; init; }
}
