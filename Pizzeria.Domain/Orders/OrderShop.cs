namespace Pizzeria.Domain.Orders;

/// <summary>
/// Магазин отправления заказа
/// </summary>
[ComplexType]
public class OrderShop
{
    /// <summary>
    /// ID магазина
    /// </summary>
    [Column(Order = 61), Required]
    public required Ulid ShopId { get; set; }

    /// <summary>
    /// наименование
    /// </summary>
    [Column(Order = 62), Required]
    public required string Name { get; set; }

    /// <summary>
    /// Адрес офиса
    /// </summary>
    [Required]
    public required OrderShopAddress Address { get; set; }
}
