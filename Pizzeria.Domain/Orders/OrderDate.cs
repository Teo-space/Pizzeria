namespace Pizzeria.Domain.Orders;

/// <summary>
/// Даты создания, изменения и готовности
/// </summary>
[ComplexType]
public class OrderDate
{
    [Column(Order = 11)]
    public required DateTime Created { get; set; }

    [Column(Order = 12)]
    public required DateTime Modified { get; set; }

    [Column(Order = 13)]
    public DateTime Ready { get; set; }
}
