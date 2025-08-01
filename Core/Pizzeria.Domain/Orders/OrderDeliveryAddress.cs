﻿namespace Pizzeria.Domain.Orders;

/// <summary>
/// Адрес доставки заказа
/// </summary>
public sealed record OrderDeliveryAddress
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
    /// Квартира
    /// </summary>
    public required string Apartment { get; set; }
    /// <summary>
    /// Подъезд
    /// </summary>
    public string Entrance { get; set; }
    /// <summary>
    /// Этаж
    /// </summary>
    public string Floor { get; set; }
}
