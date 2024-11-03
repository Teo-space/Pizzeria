namespace Pizzeria.Domain.Payments;


/// <summary>
/// Способ оплаты
/// </summary>
public class PaymentType : Entity
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
