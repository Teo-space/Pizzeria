namespace Pizzeria.Domain.Deliveries;

/// <summary>
/// Статусы доставки
/// </summary>
public enum DeliveryStatus
{
    /// <summary>
    /// Ожидает
    /// </summary>
    Pending = 0,
    /// <summary>
    /// Взят в работу
    /// </summary>
    InWork = 100,
    /// <summary>
    /// В процессе доставки
    /// </summary>
    Delivering = 200,
    /// <summary>
    /// Доставлен
    /// </summary>
    Ready = 1000,
    /// <summary>
    /// Отменена
    /// </summary>
    Canceled = -1000,
}
