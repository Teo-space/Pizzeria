using Pizzeria.Models.Deliveries;

namespace Pizzeria.Interfaces.Services;
public interface IDeliveriesService
{
    public Task<IReadOnlyCollection<DeliveryTypeModel>> GetDeliveryTypes();
}
