﻿namespace Pizzeria.Services.Models.Orders.OrderCheckOut.Input;

public class OrderDeliveryInputModel
{
    /// <summary>
    /// ID типа доставки
    /// </summary>
    public required Ulid TypeId { get; set; }

    /// <summary>
    /// Адрес доставки
    /// </summary>
    public OrderDeliveryAddressInputModel Address { get; set; }
}