namespace Pizzeria.Models.Deliveries;


/// <summary>
/// тип доставки
/// </summary>
public sealed record DeliveryTypeModel : OutputModel
{
    /// <summary>
    /// ID типа доставки
    /// </summary>
    public int DeliveryTypeId { get; init; }

    /// <summary>
    /// наименование
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Цена
    /// </summary>
    public decimal Price { get; init; }

    /// <summary>
    /// Доставка бесплатно с суммы заказа
    /// </summary>
    public decimal DeliveryFreeOrder { get; init; }
}
