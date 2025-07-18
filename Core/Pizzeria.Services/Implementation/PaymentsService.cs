using Mapster;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Interfaces.Repositories;
using Pizzeria.Interfaces.Services;
using Pizzeria.Models.Payments;

namespace Pizzeria.Services.Implementation;

internal class PaymentsService(IReadOnlyRepository readOnlyRepository) : IPaymentsService
{
    public async Task<IReadOnlyCollection<PaymentTypeModel>> GetPaymentTypes()
    {
        return await readOnlyRepository.PaymentTypes.ProjectToType<PaymentTypeModel>().ToListAsync();
    }
}
