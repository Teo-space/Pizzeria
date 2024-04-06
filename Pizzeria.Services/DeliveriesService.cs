using Mapster;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Interfaces.Models.Deliveries;
using Pizzeria.Interfaces.Repositories;
using Pizzeria.Interfaces.Services;

namespace Pizzeria.Services;

internal class DeliveriesService(IReadOnlyRepository readOnlyRepository) : IDeliveriesService
{
    public async Task<IReadOnlyCollection<DeliveryTypeModel>> GetDeliveryTypes()
    {
        return await readOnlyRepository.DeliveryTypes.ProjectToType<DeliveryTypeModel>().ToListAsync();
    }
}
