using Pizzeria.Domain.Enums;

namespace Pizzeria.Models.Orders.GetOrderDetail;


/// <summary>
/// Платеж заказа
/// </summary>
public sealed record OrderPaymentModel : OutputModel
{
    /// <summary>
    /// Способ оплаты
    /// </summary>
    public PaymentTypes Type { get; init; }

    /// <summary>
    /// Сумма платежа
    /// </summary>
    public decimal Sum { get; init; }

    /// <summary>
    /// Дата платежа
    /// </summary>
    public string Payed { get; init; }
    /// <summary>
    /// Оплачено
    /// </summary>
    public bool IsPayed { get; init; }
}
