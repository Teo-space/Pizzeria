namespace Pizzeria.Services;

using Pizzeria.Interfaces.Models.Catalog;
using Pizzeria.Interfaces.Services;

internal class CatalogService(
    IDeliveriesService deliveriesService,
    IPaymentsService paymentsService,
    IProductsService productsService,
    IShopsService shopsService) : ICatalogService
{

    public async Task<CatalogModel> GetCatalog()
    {
        var deliveryTypes = deliveriesService.GetDeliveryTypes();
        var paymentTypes = paymentsService.GetPaymentTypes();
        var shops = shopsService.GetShops();
        var productTypes = productsService.GetProductTypes();

        await Task.WhenAll(deliveryTypes, paymentTypes, shops, productTypes);

        var model = new CatalogModel
        {
            DeliveryTypes = deliveryTypes.Result,
            PaymentTypes = paymentTypes.Result,
            Shops = shops.Result,
            ProductTypes = productTypes.Result,
        };

        return model;
    }
}
