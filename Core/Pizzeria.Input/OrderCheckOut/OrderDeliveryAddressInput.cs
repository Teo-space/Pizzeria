namespace Pizzeria.Rest.Input.OrderCheckOut;

public sealed record OrderDeliveryAddressInput
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
    /// Квартира
    /// </summary>
    public required string Apartment { get; init; }
    /// <summary>
    /// Подъезд
    /// </summary>
    public string Entrance { get; init; }
    /// <summary>
    /// Этаж
    /// </summary>
    public string Floor { get; init; }
}
