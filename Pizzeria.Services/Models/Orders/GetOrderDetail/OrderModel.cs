using Pizzeria.Domain.Orders;

namespace Pizzeria.Services.Models.Orders.GetOrderDetail;

/// <summary>
/// Заказ
/// </summary>
public record OrderModel
{
    /// <summary>
    /// Идентификатор заказа
    /// </summary>
    public string OrderId { get; set; }

    /// <summary>
    /// Даты создания, изменения и готовности
    /// </summary>
    public OrderDateModel Date { get; set; }
    /// <summary>
    /// Информация о клиенте
    /// </summary>
    public OrderClient Client { get; set; }

    /// <summary>
    /// Информация о доставке
    /// </summary>
    public OrderDeliveryModel Delivery { get; set; }
    /// <summary>
    /// Оплата
    /// </summary>
    public OrderPaymentModel Payment { get; private set; }
    /// <summary>
    /// информация о магазине
    /// </summary>
    public OrderShopModel Shop { get; private set; }


    /// <summary>
    /// Позиции заказа
    /// </summary>
    public HashSet<OrderPositionModel> Positions { get; set; } = new HashSet<OrderPositionModel>();
}
