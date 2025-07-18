namespace Pizzeria.Domain.Shops;


/// <summary>
/// Адрес магазина
/// </summary>
public sealed record ShopAddress
{
    /// <summary>
    /// Город
    /// </summary>
    public required string City { get; set; }
    /// <summary>
    /// Улица
    /// </summary>
    public required string Street { get; set; }
    /// <summary>
    /// Дом
    /// </summary>
    public required string House { get; set; }
    /// <summary>
    /// Корпус \ строение
    /// </summary>
    public required string Building { get; set; }
    /// <summary>
    /// офис
    /// </summary>
    public string? Office { get; set; }
}
