using Pizzeria.Models.Payments;

namespace Pizzeria.Interfaces.Services;
public interface IPaymentsService
{
    public Task<IReadOnlyCollection<PaymentTypeModel>> GetPaymentTypes();
}
