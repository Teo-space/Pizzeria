﻿namespace Pizzeria.Interfaces.Params.Orders.OrderCheckOut;

public class OrderClientParam
{
    /// <summary>
    /// Номер телефона
    /// </summary>
    public long Phone { get; set; }
    /// <summary>
    /// адрес эл. почты
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Фамилия
    /// </summary>
    public string SurName { get; set; }
    /// <summary>
    /// Отчество
    /// </summary>
    public string Patronymic { get; set; }
}
