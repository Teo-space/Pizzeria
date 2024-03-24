namespace Pizzeria.Domain.Orders;

/// <summary>
/// Адрес доставки заказа
/// </summary>
[ComplexType]
public class OrderDeliveryAddress
{
    /// <summary>
    /// Город
    /// </summary>
    [Column(Order = 41), Required]
    public required string City { get; set; }
    /// <summary>
    /// Улица
    /// </summary>
    [Column(Order = 42), Required]
    public required string Street { get; set; }
    /// <summary>
    /// Дом
    /// </summary>
    [Column(Order = 43), Required]
    public required string House { get; set; }
    /// <summary>
    /// Квартира
    /// </summary>
    [Column(Order = 44), Required]
    public required string Apartment { get; set; }
    /// <summary>
    /// Подъезд
    /// </summary>
    [Column(Order = 45)]
    public string Entrance { get; set; }
    /// <summary>
    /// Этаж
    /// </summary>
    [Column(Order = 46)]
    public string Floor { get; set; }
}
