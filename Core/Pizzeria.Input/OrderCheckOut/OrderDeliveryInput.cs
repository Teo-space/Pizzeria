﻿namespace Pizzeria.Rest.Input.OrderCheckOut;

public sealed record OrderDeliveryInput
{
    /// <summary>
    /// ID типа доставки
    /// </summary>
    public required int DeliveryTypeId { get; init; }

    /// <summary>
    /// Адрес доставки
    /// </summary>
    public OrderDeliveryAddressInput Address { get; init; }
}
