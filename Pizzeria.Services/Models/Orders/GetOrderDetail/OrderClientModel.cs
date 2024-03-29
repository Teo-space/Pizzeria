namespace Pizzeria.Services.Models.Orders.GetOrderDetail;


/// <summary>
/// Покупатель заказа
/// </summary>
public class OrderClientModel
{
    /// <summary>
    /// Номер телефона
    /// </summary>
    public required long Phone { get; set; }

    /// <summary>
    /// адрес эл. почты
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public required string SurName { get; set; }

    /// <summary>
    /// Отчество
    /// </summary>
    public required string Patronymic { get; set; }
}
