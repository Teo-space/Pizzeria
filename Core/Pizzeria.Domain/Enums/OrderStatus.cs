﻿
/// <summary>
/// Статус заказа
/// Pending
/// Происходит проверка менеджером состава заказа, адреса, потом контрольный звонок
/// После чего менеджер либо подтверждает либо отклоняет заказ
/// Approve: 
/// если в составе заказа есть позиции которые требуют приготовления то статус становится CookingPending и заказ передается на кухню
/// если в составе нет позиций которые требуют приготовления то статус сразу становится DeliveryPending
/// </summary>
public enum OrderStatus
{
    /// <summary>
    /// Ожидает
    /// </summary>
    Pending = 0,

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

    /// <summary>
    /// отменен
    /// </summary>
    Canceled = 10000,
}
