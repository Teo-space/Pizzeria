﻿using Pizzeria.Domain.Payments;

namespace Pizzeria.Interfaces.Models.Orders.OrderCheckOut.Input;

/// <summary>
/// Оформление заказа
/// </summary>
public class OrderInputModel
{
    /// <summary>
    /// Информация о клиенте
    /// </summary>
    public required OrderClientInputModel Client { get; set; }
    /// <summary>
    /// Информация о магазине
    /// </summary>
    public required OrderShopInputModel Shop { get; set; }
    /// <summary>
    /// Информация о доставке
    /// </summary>
    public required OrderDeliveryInputModel Delivery { get; set; }
    /// <summary>
    /// Тип оплаты
    /// </summary>
    public required PaymentTypes PaymentType { get; set; }
    /// <summary>
    /// Позиции заказа
    /// </summary>
    public required IReadOnlyCollection<OrderBasketPositionInputModel> Positions { get; set; }
        = new List<OrderBasketPositionInputModel>();
}