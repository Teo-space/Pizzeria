namespace Pizzeria.Interfaces.Models.Orders.GetOrderDetail;


/// <summary>
/// Даты создания, изменения и готовности
/// </summary>
public record OrderDateModel
{
    /// <summary>
    /// Дата создания
    /// </summary>
    public string Created { get; set; }
    /// <summary>
    /// Дата изменения
    /// </summary>
    public string Modified { get; set; }
    /// <summary>
    /// дата завершения
    /// </summary>
    public string Ready { get; set; }
}
