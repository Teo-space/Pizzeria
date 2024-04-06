namespace Pizzeria.Interfaces.Services;

using Pizzeria.Interfaces.Models.Deliveries;


public interface IDeliveriesService
{
    public Task<IReadOnlyCollection<DeliveryTypeModel>> GetDeliveryTypes();
}
