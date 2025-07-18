using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Domain.Orders;

/// <summary>
/// Магазин отправления заказа
/// </summary>
public sealed record OrderShop
{
    /// <summary>
    /// ID магазина
    /// </summary>
    public required int ShopId { get; set; }

    /// <summary>
    /// наименование
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Адрес офиса
    /// </summary>
    [Required]
    public required OrderShopAddress Address { get; set; }
}
