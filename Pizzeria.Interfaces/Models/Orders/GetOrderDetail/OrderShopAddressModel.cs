namespace Pizzeria.Interfaces.Models.Orders.GetOrderDetail;

/// <summary>
/// Адрес магазина
/// </summary>
public record OrderShopAddressModel
{
    /// <summary>
    /// Город
    /// </summary>
    public string City { get; set; }
    /// <summary>
    /// Улица
    /// </summary>
    public string Street { get; set; }
    /// <summary>
    /// Дом
    /// </summary>
    public string House { get; set; }
    /// <summary>
    /// Корпус \ строение
    /// </summary>
    public string Building { get; set; }
    /// <summary>
    /// офис
    /// </summary>
    public string Office { get; set; }
}
