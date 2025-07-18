namespace Pizzeria.Rest.Input.OrderCheckOut;

public sealed record OrderBasketPositionInput
{
    /// <summary>
    /// Идентификатор варианта продукта
    /// </summary>
    public required Ulid ProductId { get; init; }
    /// <summary>
    /// Количество для заказа
    /// </summary>
    public required int Quantity { get; init; }
}
