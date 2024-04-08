using Pizzeria.Domain.Payments;

namespace Pizzeria.Interfaces.Params.Orders.OrderCheckOut;

/// <summary>
/// Оформление заказа
/// </summary>
public class OrderParam
{
    /// <summary>
    /// Информация о клиенте
    /// </summary>
    public required OrderClientParam Client { get; set; }
    /// <summary>
    /// Информация о магазине
    /// </summary>
    public required OrderShopParam Shop { get; set; }
    /// <summary>
    /// Информация о доставке
    /// </summary>
    public required OrderDeliveryParam Delivery { get; set; }
    /// <summary>
    /// Тип оплаты
    /// </summary>
    public required PaymentTypes PaymentType { get; set; }
    /// <summary>
    /// Позиции заказа
    /// </summary>
    public required IReadOnlyCollection<OrderBasketPositionParam> Positions { get; set; }
        = new List<OrderBasketPositionParam>();
}
