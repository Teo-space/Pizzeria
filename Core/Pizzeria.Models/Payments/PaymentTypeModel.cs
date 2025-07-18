namespace Pizzeria.Models.Payments;


/// <summary>
/// Способ оплаты
/// </summary>
public sealed record PaymentTypeModel : OutputModel
{
    /// <summary>
    /// Id типа оплаты
    /// </summary>
    public int PaymentTypeId { get; init; }
    /// <summary>
    /// наименование типа оплаты
    /// </summary>
    public string Name { get; init; }
}
