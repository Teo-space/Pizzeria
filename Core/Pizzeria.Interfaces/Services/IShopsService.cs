namespace Pizzeria.Interfaces.Services;

using Pizzeria.Models.Shops;

public interface IShopsService
{
    public Task<IReadOnlyCollection<ShopModel>> GetShops();
}
