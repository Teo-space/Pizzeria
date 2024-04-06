namespace Pizzeria.Interfaces.Models.Payments;


/// <summary>
/// Способ оплаты
/// </summary>
public record PaymentTypeModel
{
    /// <summary>
    /// Id типа оплаты
    /// </summary>
    public int PaymentTypeId { get; set; }
    /// <summary>
    /// наименование типа оплаты
    /// </summary>
    public string Name { get; set; }
}
