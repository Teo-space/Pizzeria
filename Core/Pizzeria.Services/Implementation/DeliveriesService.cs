using Mapster;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Interfaces.Repositories;
using Pizzeria.Interfaces.Services;
using Pizzeria.Models.Deliveries;

namespace Pizzeria.Services.Implementation;

internal class DeliveriesService(IReadOnlyRepository readOnlyRepository) : IDeliveriesService
{
    public async Task<IReadOnlyCollection<DeliveryTypeModel>> GetDeliveryTypes()
    {
        return await readOnlyRepository.DeliveryTypes.ProjectToType<DeliveryTypeModel>().ToListAsync();
    }
}
