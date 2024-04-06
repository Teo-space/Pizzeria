using Pizzeria.Interfaces.Models.Payments;

namespace Pizzeria.Persistence.SeedWork;

public static class PaymentTypesFactory
{
    public static IReadOnlyCollection<PaymentType> GetPaymentTypes =>
        new List<PaymentType>
        {
            new PaymentType
            {
                PaymentTypeId = (int)PaymentTypes.CashInOffice,
                Name = "Наличными в офисе"
            },
            new PaymentType
            {
                PaymentTypeId = (int)PaymentTypes.CashToCourier,
                Name = "Наличными курьеру"
            },
            new PaymentType
            {
                PaymentTypeId = (int)PaymentTypes.CardInOffice,
                Name = "Картой в офисе"
            },
            new PaymentType
            {
                PaymentTypeId = (int)PaymentTypes.CardToCourier,
                Name = "Картой курьеру"
            },
        };
}
