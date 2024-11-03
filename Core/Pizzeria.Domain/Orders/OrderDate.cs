namespace Pizzeria.Domain.Orders;

/// <summary>
/// Даты создания, изменения и готовности
/// </summary>
public record OrderDate
{
    /// <summary>
    /// Дата создания
    /// </summary>
    public required DateTime Created { get; set; }
    /// <summary>
    /// Дата изменения
    /// </summary>
    public required DateTime Modified { get; set; }
    /// <summary>
    /// дата завершения
    /// </summary>
    public DateTime Ready { get; set; }
}
