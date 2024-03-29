namespace Pizzeria.Services.Models.Orders.OrderCheckOut.Input;

public class OrderBasketPositionInputModel
{
    /// <summary>
    /// Идентификатор варианта продукта
    /// </summary>
    public required Ulid ProductId { get; set; }
    /// <summary>
    /// Количество для заказа
    /// </summary>
    public required int Quantity { get; set; }
}
