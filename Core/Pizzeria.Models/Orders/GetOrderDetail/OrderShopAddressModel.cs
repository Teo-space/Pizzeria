namespace Pizzeria.Models.Orders.GetOrderDetail;

/// <summary>
/// Адрес магазина
/// </summary>
public sealed record OrderShopAddressModel : OutputModel
{
    /// <summary>
    /// Город
    /// </summary>
    public string City { get; init; }
    /// <summary>
    /// Улица
    /// </summary>
    public string Street { get; init; }
    /// <summary>
    /// Дом
    /// </summary>
    public string House { get; init; }
    /// <summary>
    /// Корпус \ строение
    /// </summary>
    public string Building { get; init; }
    /// <summary>
    /// офис
    /// </summary>
    public string Office { get; init; }
}
