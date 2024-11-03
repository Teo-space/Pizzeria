using Pizzeria.Interfaces.Models.Orders.GetOrderDetail;
using Pizzeria.Interfaces.Params.Orders.GetOrderDetail;
using Pizzeria.Interfaces.Params.Orders.OrderCheckOut;

namespace Pizzeria.Interfaces.Services;

/// <summary>
/// Заказы
/// </summary>
public interface IOrdersService
{
    /// <summary>
    /// оформить заказ
    /// </summary>
    Task<Ulid> OrderCheckOut(OrderParam inputModel);

    /// <summary>
    /// детализация по заказу
    /// </summary>
    Task<OrderModel> GetOrderDetail(GetOrderDetailParam inputModel);
}
