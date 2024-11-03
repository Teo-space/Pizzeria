namespace Pizzeria.Interfaces.Services;

using Pizzeria.Interfaces.Models.Payments;


public interface IPaymentsService
{
    public Task<IReadOnlyCollection<PaymentTypeModel>> GetPaymentTypes();
}
