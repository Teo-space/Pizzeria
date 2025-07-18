namespace Pizzeria.Models.Orders.GetOrderDetail;

/// <summary>
/// Адрес доставки заказа
/// </summary>
public sealed record OrderDeliveryAddressModel : OutputModel
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
    /// Квартира
    /// </summary>
    public string Apartment { get; init; }

    /// <summary>
    /// Подъезд
    /// </summary>
    public string Entrance { get; init; }

    /// <summary>
    /// Этаж
    /// </summary>
    public string Floor { get; init; }
}
