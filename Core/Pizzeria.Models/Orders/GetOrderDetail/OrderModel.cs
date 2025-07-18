using Pizzeria.Domain.Orders;

namespace Pizzeria.Models.Orders.GetOrderDetail;

/// <summary>
/// Заказ
/// </summary>
public sealed record OrderModel : OutputModel
{
    /// <summary>
    /// Идентификатор заказа
    /// </summary>
    public string OrderId { get; init; }

    /// <summary>
    /// Даты создания, изменения и готовности
    /// </summary>
    public OrderDateModel Date { get; init; }
    /// <summary>
    /// Информация о клиенте
    /// </summary>
    public OrderClient Client { get; init; }

    /// <summary>
    /// Информация о доставке
    /// </summary>
    public OrderDeliveryModel Delivery { get; init; }
    /// <summary>
    /// Оплата
    /// </summary>
    public OrderPaymentModel Payment { get; private init; }
    /// <summary>
    /// информация о магазине
    /// </summary>
    public OrderShopModel Shop { get; private init; }


    /// <summary>
    /// Позиции заказа
    /// </summary>
    public IReadOnlyCollection<OrderPositionModel> Positions { get; init; } = Array.Empty<OrderPositionModel>();
}
