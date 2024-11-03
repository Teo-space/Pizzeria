using Pizzeria.Domain.Payments;

namespace Pizzeria.Rest.Models.Orders.GetOrderDetail;


/// <summary>
/// Платеж заказа
/// </summary>
public record OrderPaymentModel
{
    /// <summary>
    /// Способ оплаты
    /// </summary>
    public PaymentTypes Type { get; set; }

    /// <summary>
    /// Сумма платежа
    /// </summary>
    public decimal Sum { get; set; }

    /// <summary>
    /// Дата платежа
    /// </summary>
    public string Payed { get; set; }
    /// <summary>
    /// Оплачено
    /// </summary>
    public bool IsPayed { get; set; }
}
