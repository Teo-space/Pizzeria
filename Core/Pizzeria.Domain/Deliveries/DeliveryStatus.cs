﻿namespace Pizzeria.Domain.Deliveries;


/// <summary>
/// Статусы доставки
/// </summary>
public sealed record DeliveryStatus : Entity
{
    /// <summary>
    /// ID статуса доставки
    /// </summary>
    public int DeliveryStatusId { get; set; }
    /// <summary>
    /// Наименование статуса доставки
    /// </summary>
    public string Name { get; set; }
}
