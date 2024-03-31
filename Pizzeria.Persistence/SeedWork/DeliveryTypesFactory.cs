namespace Pizzeria.Persistence.SeedWork;

public static class DeliveryTypesFactory
{
    public static IReadOnlyCollection<DeliveryType> GetDeliveryTypes =>
        new List<DeliveryType>
        {
            new DeliveryType
            {
                DeliveryTypeId = (int)DeliveryTypes.StorePickup,
                Name = "Самовывоз из магазина",
                Price = 0,
                DeliveryFreeOrder = 0,
            },
            new DeliveryType
            {
                DeliveryTypeId = (int)DeliveryTypes.CourierDelivery,
                Name = "Доставка курьером",
                Price = 150,
                DeliveryFreeOrder = 1000,
            },
        };
}
