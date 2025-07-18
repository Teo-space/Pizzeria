using Pizzeria.Domain.Enums;

namespace Pizzeria.Models.Orders.GetOrderDetail;

/// <summary>
/// Информация о доставке
/// </summary>
public sealed record OrderDeliveryModel : OutputModel
{
    /// <summary>
    /// ID типа доставки
    /// </summary>
    public int TypeId { get; init; }

    /// <summary>
    /// Статус доставки
    /// </summary>
    public DeliveryStatuses Status { get; init; }

    /// <summary>
    /// Дата начала доставки
    /// </summary>
    public string Start { get; init; }

    /// <summary>
    /// Дата окончания
    /// </summary>
    public string End { get; init; }

    /// <summary>
    /// Адрес доставки
    /// </summary>
    public OrderDeliveryAddressModel Address { get; init; }
}
