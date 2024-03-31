using Pizzeria.Persistence.DbContexts;

namespace Pizzeria.Persistence.SeedWork;

internal class ApplySeedsToContext
{
    public static void ApplySeeds(PizzeriaDbContext dbContext)
    {
        if(!dbContext.DeliveryStatuses.Any() )
        {
            dbContext.DeliveryStatuses.AddRange(DeliveryStatusesFactory.GetDeliveryStatuses);
        }
        if(!dbContext.DeliveryTypes.Any() )
        {
            dbContext.DeliveryTypes.AddRange(DeliveryTypesFactory.GetDeliveryTypes);
        }
        if(!dbContext.PaymentTypes.Any() )
        {
            dbContext.PaymentTypes.AddRange(PaymentTypesFactory.GetPaymentTypes);
        }
        if(!dbContext.Shops.Any() )
        {
            dbContext.Shops.AddRange(ShopsFactory.GetShops);
        }

        dbContext.SaveChanges();
    }
}
