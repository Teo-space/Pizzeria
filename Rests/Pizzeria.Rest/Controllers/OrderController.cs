using Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Pizzeria.Interfaces.Services;
using Pizzeria.Models.Orders.GetOrderDetail;
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
    [HttpGet, Produces(typeof(OrderModel))]
    [ResponseCache(Duration = 30)]
    public async Task<ActionResult> GetOrderDetail(GetOrderDetailInput input) => await ordersService.GetOrderDetail(input);

    /// <summary>
    /// оформить заказ
    /// </summary>
    [HttpPost, Produces(typeof(string))]
    public async Task<IActionResult> OrderCheckOut(OrderCheckOutInput input)
    {
        Ulid OrderId = await ordersService.OrderCheckOut(input);

        return Ok(OrderId.ToString());
    }


}
