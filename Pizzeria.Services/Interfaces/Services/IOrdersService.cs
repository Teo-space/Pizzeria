using Pizzeria.Services.Models.Orders.OrderCheckOut.Input;

namespace Pizzeria.Services.Interfaces.Services;

public interface IOrdersService
{
    Task<Ulid> OrderCheckOut(OrderInputModel inputModel);

}
