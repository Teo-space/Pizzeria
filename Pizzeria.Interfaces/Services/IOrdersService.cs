using Pizzeria.Interfaces.Models.Orders.GetOrderDetail;
using Pizzeria.Interfaces.Models.Orders.GetOrderDetail.Input;
using Pizzeria.Interfaces.Models.Orders.OrderCheckOut.Input;

namespace Pizzeria.Interfaces.Services;

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
    Task<OrderModel> GetOrderDetail(GetOrderDetailInputModel inputModel);
}
