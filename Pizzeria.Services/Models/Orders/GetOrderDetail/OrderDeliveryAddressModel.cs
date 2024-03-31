namespace Pizzeria.Services.Models.Orders.GetOrderDetail;

/// <summary>
/// Адрес доставки заказа
/// </summary>
public record OrderDeliveryAddressModel
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
    /// Квартира
    /// </summary>
    public string Apartment { get; set; }

    /// <summary>
    /// Подъезд
    /// </summary>
    public string Entrance { get; set; }

    /// <summary>
    /// Этаж
    /// </summary>
    public string Floor { get; set; }
}
