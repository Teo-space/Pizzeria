﻿namespace Pizzeria.Domain.Orders;

/// <summary>
/// Информация о доставке
/// </summary>
public class OrderDelivery
{
    /// <summary>
    /// ID типа доставки
    /// </summary>
    public required int TypeId { get; set; }

    /// <summary>
    /// Статус доставки
    /// </summary>
    public required DeliveryStatuses Status { get; set; }

    /// <summary>
    /// Дата начала доставки
    /// </summary>
    public DateTime Start { get; internal set; }
    /// <summary>
    /// Дата окончания
    /// </summary>
    public DateTime End { get; internal set; }

    /// <summary>
    /// Адрес доставки
    /// </summary>
    public required OrderDeliveryAddress Address { get; set; }
}
