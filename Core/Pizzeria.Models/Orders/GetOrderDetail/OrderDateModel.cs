namespace Pizzeria.Models.Orders.GetOrderDetail;


/// <summary>
/// Даты создания, изменения и готовности
/// </summary>
public sealed record OrderDateModel : OutputModel
{
    /// <summary>
    /// Дата создания
    /// </summary>
    public string Created { get; init; }
    /// <summary>
    /// Дата изменения
    /// </summary>
    public string Modified { get; init; }
    /// <summary>
    /// дата завершения
    /// </summary>
    public string Ready { get; init; }
}
