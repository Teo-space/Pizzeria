using Api.Controllers;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Pizzeria.Interfaces.Models.Orders.GetOrderDetail;
using Pizzeria.Interfaces.Params.Orders.GetOrderDetail;
using Pizzeria.Interfaces.Params.Orders.OrderCheckOut;
using Pizzeria.Interfaces.Services;
using Pizzeria.Rest.Input.GetOrderDetail;
using Pizzeria.Rest.Input.OrderCheckOut;

namespace Pizzeria.Rest.Controllers;


/// <summary>
/// Заказы
/// </summary>
[Route($"{Prefix}/[controller]")]
public class OrderController(IOrdersService ordersService) : ApiBaseController
{
    /// <summary>
    /// детализация по заказу
    /// </summary>
    [HttpGet]
    [ResponseCache(Duration = 30)]
    [Produces(typeof(OrderModel))]
    public async Task<IActionResult> GetOrderDetail(GetOrderDetailInput input)
    {
        var model = await ordersService.GetOrderDetail(input.Adapt<GetOrderDetailParam>());

        var result = model.Adapt<OrderModel>();

        return Ok(result);
    }

    /// <summary>
    /// оформить заказ
    /// </summary>
    [HttpPost]
    [Produces(typeof(Ulid))]
    public async Task<IActionResult> GetOrderDetail(OrderInput input)
    {
        var OrderId = await ordersService.OrderCheckOut(input.Adapt<OrderParam>());

        return Ok(OrderId);
    }


}
