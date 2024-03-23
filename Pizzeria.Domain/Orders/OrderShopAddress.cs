using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Domain.Shops;

/// <summary>
/// Адрес магазина
/// </summary>
[ComplexType]
public class OrderShopAddress
{
    /// <summary>
    /// Город
    /// </summary>
    [Column(Order = 71), Required]
    public required string City { get; set; }
    /// <summary>
    /// Улица
    /// </summary>
    [Column(Order = 72), Required]
    public required string Street { get; set; }
    /// <summary>
    /// Дом
    /// </summary>
    [Column(Order = 73), Required]
    public required string House { get; set; }
    /// <summary>
    /// Корпус \ строение
    /// </summary>
    [Column(Order = 74), Required]
    public required string Building { get; set; }
    /// <summary>
    /// офис
    /// </summary>
    [Column(Order = 75)]
    public string Office { get; set; }
}
