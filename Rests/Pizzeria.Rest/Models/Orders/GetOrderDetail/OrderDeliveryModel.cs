using Pizzeria.Domain.Deliveries;

namespace Pizzeria.Rest.Models.Orders.GetOrderDetail;

/// <summary>
/// Информация о доставке
/// </summary>
public record OrderDeliveryModel
{
    /// <summary>
    /// ID типа доставки
    /// </summary>
    public int TypeId { get; set; }

    /// <summary>
    /// Статус доставки
    /// </summary>
    public DeliveryStatuses Status { get; set; }

    /// <summary>
    /// Дата начала доставки
    /// </summary>
    public string Start { get; set; }

    /// <summary>
    /// Дата окончания
    /// </summary>
    public string End { get; set; }

    /// <summary>
    /// Адрес доставки
    /// </summary>
    public OrderDeliveryAddressModel Address { get; set; }
}
