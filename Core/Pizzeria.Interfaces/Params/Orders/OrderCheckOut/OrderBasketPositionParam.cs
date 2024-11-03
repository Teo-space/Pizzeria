namespace Pizzeria.Interfaces.Params.Orders.OrderCheckOut;

public class OrderBasketPositionParam
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
