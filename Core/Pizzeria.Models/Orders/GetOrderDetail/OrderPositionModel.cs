namespace Pizzeria.Models.Orders.GetOrderDetail;


/// <summary>
/// позиция заказа
/// </summary>
public sealed record OrderPositionModel : OutputModel
{
    /// <summary>
    /// ID позиции заказа
    /// </summary>
    public Ulid OrderPositionId { get; init; }

    /// <summary>
    /// наименование продукта
    /// </summary>
    public string ProductName { get; init; }

    /// <summary>
    /// количество
    /// </summary>
    public int Quanity { get; init; }
    /// <summary>
    /// Цена
    /// </summary>
    public decimal Price { get; init; }

    /// <summary>
    /// Сумма
    /// </summary>
    public decimal Sum { get => Quanity * Price; }
}
