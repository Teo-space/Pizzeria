﻿namespace Pizzeria.Domain.Deliveries;


/// <summary>
/// тип доставки
/// </summary>
public sealed record DeliveryType : Entity
{
    /// <summary>
    /// ID типа доставки
    /// </summary>
    public int DeliveryTypeId { get; set; }

    /// <summary>
    /// наименование
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Цена
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Доставка бесплатно с суммы заказа
    /// </summary>
    public decimal DeliveryFreeOrder { get; set; }
}
