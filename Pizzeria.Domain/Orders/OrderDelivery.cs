namespace Pizzeria.Domain.Orders;

/// <summary>
/// Информация о доставке
/// </summary>
[ComplexType]
public class OrderDelivery
{
    /// <summary>
    /// ID типа доставки
    /// </summary>
    [Column(Order = 31), Required]
    public required Ulid TypeId { get; set; }

    /// <summary>
    /// Статус доставки
    /// </summary>
    [Column(Order = 32), Required]
    public required DeliveryStatus Status { get; set; }

    /// <summary>
    /// Дата начала доставки
    /// </summary>
    [Column(Order = 33), Required]
    public DateTime Start { get; internal set; }
    /// <summary>
    /// Дата окончания
    /// </summary>
    [Column(Order = 34), Required]
    public DateTime End { get; internal set; }
    /// <summary>
    /// Адрес доставки
    /// </summary>
    [Column(Order = 35), Required]
    public required OrderDeliveryAddress Address { get; set; }
}
