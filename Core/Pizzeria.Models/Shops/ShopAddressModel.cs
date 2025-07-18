namespace Pizzeria.Models.Shops;


/// <summary>
/// Адрес магазина
/// </summary>
public sealed record ShopAddressModel : OutputModel
{
    /// <summary>
    /// Город
    /// </summary>
    public required string City { get; init; }
    /// <summary>
    /// Улица
    /// </summary>
    public required string Street { get; init; }
    /// <summary>
    /// Дом
    /// </summary>
    public required string House { get; init; }
    /// <summary>
    /// Корпус \ строение
    /// </summary>
    public required string Building { get; init; }
    /// <summary>
    /// офис
    /// </summary>
    public string Office { get; init; }
}
