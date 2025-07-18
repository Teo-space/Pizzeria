using Pizzeria.Domain.Enums;

namespace Pizzeria.Domain.Orders;

/// <summary>
/// Информация о доставке
/// </summary>
public sealed record OrderDelivery
{
    /// <summary>
    /// ID типа доставки
    /// </summary>
    public required int TypeId { get; set; }

    /// <summary>
    /// Статус доставки
    /// </summary>
    public required DeliveryStatuses Status { get; set; }

    /// <summary>
    /// Дата начала доставки
    /// </summary>
    public DateTime Start { get; set; }
    /// <summary>
    /// Дата окончания
    /// </summary>
    public DateTime End { get; set; }

    /// <summary>
    /// Адрес доставки
    /// </summary>
    public required OrderDeliveryAddress Address { get; set; }
}
