namespace Pizzeria.Interfaces.Services;

using Pizzeria.Interfaces.Models.Shops;

public interface IShopsService
{
    public Task<IReadOnlyCollection<ShopModel>> GetShops();
}
