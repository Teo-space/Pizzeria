using Pizzeria.Domain.Enums;

namespace Pizzeria.Persistence.SeedWork;

public static class DeliveryStatusesFactory
{
    public static IReadOnlyCollection<DeliveryStatus> GetDeliveryStatuses =>
        new List<DeliveryStatus>
        {
            new DeliveryStatus
            {
                DeliveryStatusId = (int)DeliveryStatuses.Pending,
                Name = "Ожидает"
            },
            new DeliveryStatus
            {
                DeliveryStatusId = (int)DeliveryStatuses.InWork,
                Name = "Взят в работу"
            },
            new DeliveryStatus
            {
                DeliveryStatusId = (int)DeliveryStatuses.Delivering,
                Name = "В процессе доставки"
            },
            new DeliveryStatus
            {
                DeliveryStatusId = (int)DeliveryStatuses.Ready,
                Name = "Доставлен"
            },
            new DeliveryStatus
            {
                DeliveryStatusId = (int)DeliveryStatuses.Canceled,
                Name = "Отменен"
            },
        };




}
