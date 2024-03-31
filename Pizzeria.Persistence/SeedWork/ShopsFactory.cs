namespace Pizzeria.Persistence.SeedWork;

public static class ShopsFactory
{
    public static IReadOnlyCollection<Shop> GetShops =>
        new List<Shop>
        {
            new Shop
            {
                ShopId = (int)MainShops.Main,
                Name = "Пиццерия на улице Пролетарской",

                Address = new ShopAddress()
                {
                    City = "Москва",
                    Street = "Пролетарская",
                    House = "100",
                    Building = "1В"
                }
            }
        };
}
