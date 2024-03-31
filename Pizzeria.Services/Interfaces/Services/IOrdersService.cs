using Pizzeria.Services.Models.Orders.GetOrderDetail;
using Pizzeria.Services.Models.Orders.OrderCheckOut.Input;

namespace Pizzeria.Services.Interfaces.Services;

/// <summary>
/// Заказы
/// </summary>
public interface IOrdersService
{
    /// <summary>
    /// оформить заказ
    /// </summary>
    Task<Ulid> OrderCheckOut(OrderInputModel inputModel);

    /// <summary>
    /// детализация по заказу
    /// </summary>
    Task<OrderModel> GetOrderDetail(Ulid orderId);
}
