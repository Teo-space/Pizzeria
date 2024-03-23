namespace Pizzeria.Domain;


/// <summary>
/// Даты создания, изменения и готовности
/// </summary>
[ComplexType]
public class Date
{
    [Column(Order = 11)]
    public DateTime Created { get; internal set; }

    [Column(Order = 12)]
    public DateTime Modified { get; internal set; }

    [Column(Order = 13)]
    public DateTime Ready { get; internal set; }
}
