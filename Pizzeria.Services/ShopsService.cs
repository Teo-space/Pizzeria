using Mapster;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Interfaces.Models.Shops;
using Pizzeria.Interfaces.Repositories;
using Pizzeria.Interfaces.Services;

namespace Pizzeria.Services;

internal class ShopsService(IReadOnlyRepository readOnlyRepository) : IShopsService
{
    public async Task<IReadOnlyCollection<ShopModel>> GetShops()
    {
        return await readOnlyRepository.PaymentTypes.ProjectToType<ShopModel>().ToListAsync();
    }
}
