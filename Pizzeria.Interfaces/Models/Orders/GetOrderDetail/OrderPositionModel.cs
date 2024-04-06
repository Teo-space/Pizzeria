namespace Pizzeria.Interfaces.Models.Orders.GetOrderDetail;


/// <summary>
/// позиция заказа
/// </summary>
public record OrderPositionModel
{
    /// <summary>
    /// ID позиции заказа
    /// </summary>
    public Ulid OrderPositionId { get; set; }

    /// <summary>
    /// наименование продукта
    /// </summary>
    public string ProductName { get; set; }

    /// <summary>
    /// количество
    /// </summary>
    public int Quanity { get; set; }
    /// <summary>
    /// Цена
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Сумма
    /// </summary>
    public decimal Sum { get => Quanity * Price; }
}
