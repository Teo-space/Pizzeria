using Mapster;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Interfaces.Models.Payments;
using Pizzeria.Interfaces.Repositories;
using Pizzeria.Interfaces.Services;

namespace Pizzeria.Services;

internal class PaymentsService(IReadOnlyRepository readOnlyRepository) : IPaymentsService
{
    public async Task<IReadOnlyCollection<PaymentTypeModel>> GetPaymentTypes()
    {
        return await readOnlyRepository.PaymentTypes.ProjectToType<PaymentTypeModel>().ToListAsync();
    }
}
