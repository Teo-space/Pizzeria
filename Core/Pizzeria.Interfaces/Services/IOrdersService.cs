using Pizzeria.Models.Orders.GetOrderDetail;
using Pizzeria.Rest.Input.GetOrderDetail;
using Pizzeria.Rest.Input.OrderCheckOut;

namespace Pizzeria.Interfaces.Services;

/// <summary>
/// Заказы
/// </summary>
public interface IOrdersService
{
    /// <summary>
    /// оформить заказ
    /// </summary>
    Task<Ulid> OrderCheckOut(OrderCheckOutInput inputModel);

    /// <summary>
    /// детализация по заказу
    /// </summary>
    Task<OrderModel> GetOrderDetail(GetOrderDetailInput inputModel);
}
