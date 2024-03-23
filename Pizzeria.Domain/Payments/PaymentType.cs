namespace Pizzeria.Domain.Payments;

/// <summary>
/// Способ оплаты
/// </summary>
public enum PaymentType
{
    /// <summary>
    /// Наличными в офисе
    /// </summary>
    CashInOffice = 100,
    /// <summary>
    /// Наличными курьеру
    /// </summary>
    CashToCourier = 200,

    /// <summary>
    /// Картой в офисе
    /// </summary>
    CardInOffice = 300,
    /// <summary>
    /// Картой курьеру
    /// </summary>
    CardToCourier = 400,

    ///Способы оплаты через партнеров

}
