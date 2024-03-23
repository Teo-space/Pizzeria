namespace Pizzeria.Domain.Orders;

public enum OrderStatus
{
    /// <summary>
    /// Ожидает
    /// </summary>
    Pending = 0,
    /// <summary>
    /// Подтвержден менеджером
    /// </summary>
    Aproved = 100,
    /// <summary>
    /// Отклонен менеджером
    /// </summary>
    Disaproved = 101,
    /// <summary>
    /// Взят в работу
    /// </summary>
    InWork = 200,

    /// <summary>
    /// Передан на кухню (в случае если в составе есть товары требующие приготовления
    /// </summary>
    CookingPending = 300,
    /// <summary>
    /// Готовится на кухне
    /// </summary>
    Cooking = 301,
    /// <summary>
    /// Приготовлен на кухне
    /// </summary>
    CookingReady = 302,

    /// <summary>
    /// Передан наборщикам
    /// </summary>
    CollectingOrder = 303,
    /// <summary>
    /// Передан в доставку
    /// </summary>
    DeliveryPending = 400,
    /// <summary>
    /// В процессе доставки
    /// </summary>
    Delivering = 401,
    /// <summary>
    /// Доставлен
    /// </summary>
    Delivered = 402,
    /// <summary>
    /// Завершен
    /// </summary>
    Finished = 1000,

}
