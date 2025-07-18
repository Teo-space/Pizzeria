namespace Pizzeria.Rest.Input.OrderCheckOut;

public sealed record OrderClientInput
{
    /// <summary>
    /// Номер телефона
    /// </summary>
    public long Phone { get; init; }
    /// <summary>
    /// адрес эл. почты
    /// </summary>
    public string Email { get; init; }
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; init; }
    /// <summary>
    /// Фамилия
    /// </summary>
    public string SurName { get; init; }
    /// <summary>
    /// Отчество
    /// </summary>
    public string Patronymic { get; init; }
}
