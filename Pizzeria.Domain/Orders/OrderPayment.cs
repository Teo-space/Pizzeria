using Pizzeria.Domain.Payments;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Domain.Orders;

/// <summary>
/// Платеж заказа
/// </summary>
[ComplexType]
public class OrderPayment
{
    /// <summary>
    /// Способ оплаты
    /// </summary>
    [Column(Order = 51), Required]
    public PaymentType Type { get; private set; }

    /// <summary>
    /// Сумма платежа
    /// </summary>
    [Column(Order = 52)]
    public decimal Sum { get; private set; }

    /// <summary>
    /// Дата платежа
    /// </summary>
    [Column(Order = 53)]
    public DateTime Payed { get; private set; }
    /// <summary>
    /// Оплачено
    /// </summary>
    [Column(Order = 54)]
    public bool IsPayed { get; private set; }



    public void MakePayment(PaymentType paymentType)
    {
        IsPayed = true;
        Payed = DateTime.Now;
        Type = paymentType;
    }
}
