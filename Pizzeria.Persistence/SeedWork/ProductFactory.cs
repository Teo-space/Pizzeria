using Pizzeria.Interfaces.Models.Products;

namespace Pizzeria.Persistence.SeedWork;

public static class ProductFactory
{
    public static Product GetProduct()
    {
        var productType = new ProductType
        {
            Name = "Пицца",
            Description = "Вкуснейшая пицца",
            NeedCooking = true
        };

        var product = new Product
        {
            ProductTypeId = productType.ProductTypeId,
            ProductType = productType,
            Name = "Гавайская пицца",
            Description = "куриное филе, ветчина, ананасы консервированные, соус коктейль, сыр моцарелла, грибы шампиньоны",
            Price = 850
        };

        return product;
    }

}
