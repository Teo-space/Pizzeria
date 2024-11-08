﻿using Domain;

namespace Pizzeria.Domain.Deliveries;


/// <summary>
/// Статусы доставки
/// </summary>
public class DeliveryStatus : Entity
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
